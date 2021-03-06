﻿Module CalcPayroll
    Public Sub Calculate()
        Dim alreadyexist As String = ""
        Dim basicsalary As Double = 0.0
        Dim ttlDeduction As Double = 0.0
        Dim ttldeductionInPercentage As Double = 0.0
        Dim finalpay As Double = 0.0
        Dim totalabsent As Integer = 0
        Dim ttlmanDeduction As Double = 0.0
        Dim ttlmandedctionInPercentage As Double = 0.0
        Dim finalmandatory As Double
        Dim otDuration As Integer = 0
        Dim otTotal As Double = 0.0

        Dim db As New HRMS_DBLinq2DataContext()

        Dim peopleRS = (From d In db.Peoples
                        Where d.people_role = "Staff").ToList

        Dim manDdtRS = (From d In db.mandatory_deductions).ToList

        For Each mand As mandatory_deduction In manDdtRS
            If (mand.deduction_format.Equals("money")) Then
                ttlmanDeduction += Convert.ToDecimal(mand.deduction_value)
            Else
                ttlmandedctionInPercentage += Convert.ToDecimal(mand.deduction_value)
            End If
        Next
        'Dim deductionRS = (From c In db.deductions
        '  Where c.deduction_date..Equals(DateTime.Now.Month) And c.current_date.Year.Equals(DateTime.Now.Year)).ToList

        For Each ppl As People In peopleRS
            basicsalary = ppl.hourly_rates * 9 * 23
            finalmandatory = ttlmanDeduction + (basicsalary * ttlmandedctionInPercentage / 100)
            'finalmandatory = basicsalary * ttlmandedctionInPercentage

            Dim deductionRS = (From c In db.deductions
                               Where c.people_id = ppl.people_id And c.deduction_date.Value.Month.Equals(DateTime.Now.Month) And c.deduction_date.Value.Year.Equals(DateTime.Now.Year)).ToList

            If (deductionRS.Count > 0) Then
                For Each ddt As deduction In deductionRS
                    If (ddt.deduction_format.Equals("money")) Then
                        ttlDeduction = ttlDeduction + ddt.deduction_value
                    Else
                        ttldeductionInPercentage = ttldeductionInPercentage + ddt.deduction_value
                    End If
                    totalabsent += 1
                Next
            End If

            Dim overtimeRS = (From c In db.overtimes
                              Where c.people_id = ppl.people_id And c.overtime_date.Value.Month.Equals(DateTime.Now.Month) And c.overtime_date.Value.Year.Equals(DateTime.Now.Year)).ToList
            If (overtimeRS.Count > 0) Then
                For Each ot As overtime In overtimeRS
                    otDuration += Convert.ToInt16(ot.overtime_duration)
                Next
                otTotal = otDuration * ppl.hourly_rates
            End If

            finalpay = basicsalary
            finalpay -= basicsalary * ttldeductionInPercentage
            finalpay -= ttlDeduction
            finalpay -= finalmandatory
            finalpay += otTotal
            'Check if payroll already have the records
            If (db.netpays.Any(Function(o) o.people_id = ppl.people_id AndAlso o.generated_date.Value.Year.Equals(DateTime.Now.Year) AndAlso o.generated_date.Value.Month.Equals(DateTime.Now.Month))) Then
                Dim payr = (From c In db.netpays
                            Where c.people_id = ppl.people_id And c.generated_date.Value.Month.Equals(DateTime.Now.Month) And c.generated_date.Value.Year.Equals(DateTime.Now.Year)).FirstOrDefault
                payr.total_attendance = 23 - totalabsent
                payr.total_absence = totalabsent
                payr.final_pay = Convert.ToDecimal(finalpay)
                payr.generated_date = DateTime.Now
                payr.ttl_mandatory_ddt = Convert.ToDecimal(finalmandatory)
                payr.ttl_deduction = Convert.ToDecimal(ttlDeduction + (basicsalary * ttldeductionInPercentage))
                'MessageBox.Show("Already exist", "Test")
            Else
                Dim np As New netpay
                np.payroll_id = Integer.Parse(NetpayID.GetNextId)
                np.people_id = ppl.people_id
                np.total_attendance = 23 - totalabsent
                np.total_absence = totalabsent
                np.final_pay = Convert.ToDecimal(finalpay)
                np.generated_date = DateTime.Now
                np.ttl_mandatory_ddt = Convert.ToDecimal(finalmandatory)
                np.ttl_deduction = Convert.ToDecimal(ttlDeduction + (basicsalary * ttldeductionInPercentage))

                db.netpays.InsertOnSubmit(np)
            End If
            db.SubmitChanges()
        Next
    End Sub
End Module

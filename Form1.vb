Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for course grades and credits
        '
        Dim gradeEnglish As Double 'Defines the variable as a value
        Dim CreditsEnglish As Double 'Defines the variable as a value
        Dim GradeMath As Double 'Defines the variable as a value
        Dim CreditsMath As Double 'Defines the variable as a value
        Dim GradeHistory As Double 'Defines the variable as a value
        Dim CreditsHistory As Double 'Defines the variable as a value
        '
        '
        '
        '
        '
        '
        '
        '

        ' Parse input from textboxes and assign to variables

        Double.TryParse(txtGradeEnglish.Text, gradeEnglish)
        Double.TryParse(txtCreditsEnglish.Text, CreditsEnglish)
        Double.TryParse(txtGradeMath.Text, GradeMath)
        Double.TryParse(txtCreditsMath.Text, CreditsMath)
        Double.TryParse(txtGradeHistory.Text, GradeHistory)
        Double.TryParse(txtCreditsHistory.Text, CreditsHistory)

        ' Calculate total grade points and total credits
        ' Grade Calculation (gradeEnglish * creditsEnglish) + (gradeMath * creditsMath) + (gradeHistory * creditsHistory)
        ' Credits Calculation creditsEnglish + creditsMath + creditsHistory

        Dim totalGradePoints As Double = (gradeEnglish * CreditsEnglish) + (GradeMath * CreditsMath) + (GradeHistory * CreditsHistory) 'Calculates the totalgrade points average
        Dim totalCredits As Double = CreditsEnglish + CreditsMath + CreditsHistory 'Calculates the totalcredits points average


        ' Calculate GPA with appropriate precision
        ' GPA Calculation totalGradePoints / totalCredits

        Dim gpaaverage As Double = totalGradePoints / totalCredits 'divides the gpa and credits average

        'Display the calculated GPA

        lblGPA.Text = gpaaverage 'outputs the average of both the credits and gpa 


    End Sub

    Private Sub txtGradeEnglish_TextChanged(sender As Object, e As EventArgs) Handles txtGradeEnglish.TextChanged

    End Sub

    Private Sub lblEnglishCredit_Click(sender As Object, e As EventArgs) Handles lblEnglishCredit.Click

    End Sub

    Private Sub lblMathCredits_Click(sender As Object, e As EventArgs) Handles lblMathCredits.Click

    End Sub

    Private Sub lblGPA_Click(sender As Object, e As EventArgs) Handles lblGPA.Click

    End Sub
End Class

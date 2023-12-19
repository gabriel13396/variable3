<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblGPA = New Label()
        btnCalculate = New Button()
        lblEnglishGrade = New Label()
        lblEnglishCredit = New Label()
        txtGradeEnglish = New TextBox()
        txtCreditsEnglish = New TextBox()
        lblMathCredits = New Label()
        lblMathGrades = New Label()
        txtCreditsMath = New TextBox()
        txtGradeMath = New TextBox()
        txtCreditsHistory = New TextBox()
        txtGradeHistory = New TextBox()
        lblHistoryCredits = New Label()
        lblHistoryGrade = New Label()
        SuspendLayout()
        ' 
        ' lblGPA
        ' 
        lblGPA.AutoSize = True
        lblGPA.Location = New Point(534, 298)
        lblGPA.Name = "lblGPA"
        lblGPA.Size = New Size(62, 15)
        lblGPA.TabIndex = 0
        lblGPA.Text = "No Grades"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(314, 298)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 1
        btnCalculate.Text = "Calculate GPA"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblEnglishGrade
        ' 
        lblEnglishGrade.AutoSize = True
        lblEnglishGrade.Location = New Point(161, 54)
        lblEnglishGrade.Name = "lblEnglishGrade"
        lblEnglishGrade.Size = New Size(79, 15)
        lblEnglishGrade.TabIndex = 2
        lblEnglishGrade.Text = "English Grade"
        ' 
        ' lblEnglishCredit
        ' 
        lblEnglishCredit.AutoSize = True
        lblEnglishCredit.Location = New Point(161, 82)
        lblEnglishCredit.Name = "lblEnglishCredit"
        lblEnglishCredit.Size = New Size(85, 15)
        lblEnglishCredit.TabIndex = 3
        lblEnglishCredit.Text = "English Credits"
        ' 
        ' txtGradeEnglish
        ' 
        txtGradeEnglish.Location = New Point(342, 52)
        txtGradeEnglish.Name = "txtGradeEnglish"
        txtGradeEnglish.Size = New Size(100, 23)
        txtGradeEnglish.TabIndex = 4
        ' 
        ' txtCreditsEnglish
        ' 
        txtCreditsEnglish.Location = New Point(342, 84)
        txtCreditsEnglish.Name = "txtCreditsEnglish"
        txtCreditsEnglish.Size = New Size(100, 23)
        txtCreditsEnglish.TabIndex = 5
        ' 
        ' lblMathCredits
        ' 
        lblMathCredits.AutoSize = True
        lblMathCredits.Location = New Point(161, 146)
        lblMathCredits.Name = "lblMathCredits"
        lblMathCredits.Size = New Size(75, 15)
        lblMathCredits.TabIndex = 7
        lblMathCredits.Text = "Math Credits"
        ' 
        ' lblMathGrades
        ' 
        lblMathGrades.AutoSize = True
        lblMathGrades.Location = New Point(161, 120)
        lblMathGrades.Name = "lblMathGrades"
        lblMathGrades.Size = New Size(69, 15)
        lblMathGrades.TabIndex = 6
        lblMathGrades.Text = "Math Grade"
        ' 
        ' txtCreditsMath
        ' 
        txtCreditsMath.Location = New Point(342, 142)
        txtCreditsMath.Name = "txtCreditsMath"
        txtCreditsMath.Size = New Size(100, 23)
        txtCreditsMath.TabIndex = 9
        ' 
        ' txtGradeMath
        ' 
        txtGradeMath.Location = New Point(342, 112)
        txtGradeMath.Name = "txtGradeMath"
        txtGradeMath.Size = New Size(100, 23)
        txtGradeMath.TabIndex = 8
        ' 
        ' txtCreditsHistory
        ' 
        txtCreditsHistory.Location = New Point(342, 211)
        txtCreditsHistory.Name = "txtCreditsHistory"
        txtCreditsHistory.Size = New Size(100, 23)
        txtCreditsHistory.TabIndex = 13
        ' 
        ' txtGradeHistory
        ' 
        txtGradeHistory.Location = New Point(342, 181)
        txtGradeHistory.Name = "txtGradeHistory"
        txtGradeHistory.Size = New Size(100, 23)
        txtGradeHistory.TabIndex = 12
        ' 
        ' lblHistoryCredits
        ' 
        lblHistoryCredits.AutoSize = True
        lblHistoryCredits.Location = New Point(161, 215)
        lblHistoryCredits.Name = "lblHistoryCredits"
        lblHistoryCredits.Size = New Size(85, 15)
        lblHistoryCredits.TabIndex = 11
        lblHistoryCredits.Text = "History Credits"
        ' 
        ' lblHistoryGrade
        ' 
        lblHistoryGrade.AutoSize = True
        lblHistoryGrade.Location = New Point(161, 189)
        lblHistoryGrade.Name = "lblHistoryGrade"
        lblHistoryGrade.Size = New Size(79, 15)
        lblHistoryGrade.TabIndex = 10
        lblHistoryGrade.Text = "History Grade"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCreditsHistory)
        Controls.Add(txtGradeHistory)
        Controls.Add(lblHistoryCredits)
        Controls.Add(lblHistoryGrade)
        Controls.Add(txtCreditsMath)
        Controls.Add(txtGradeMath)
        Controls.Add(lblMathCredits)
        Controls.Add(lblMathGrades)
        Controls.Add(txtCreditsEnglish)
        Controls.Add(txtGradeEnglish)
        Controls.Add(lblEnglishCredit)
        Controls.Add(lblEnglishGrade)
        Controls.Add(btnCalculate)
        Controls.Add(lblGPA)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGPA As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblEnglishGrade As Label
    Friend WithEvents lblEnglishCredit As Label
    Friend WithEvents txtGradeEnglish As TextBox
    Friend WithEvents txtCreditsEnglish As TextBox
    Friend WithEvents lblMathCredits As Label
    Friend WithEvents lblMathGrades As Label
    Friend WithEvents txtCreditsMath As TextBox
    Friend WithEvents txtGradeMath As TextBox
    Friend WithEvents txtCreditsHistory As TextBox
    Friend WithEvents txtGradeHistory As TextBox
    Friend WithEvents lblHistoryCredits As Label
    Friend WithEvents lblHistoryGrade As Label
End Class

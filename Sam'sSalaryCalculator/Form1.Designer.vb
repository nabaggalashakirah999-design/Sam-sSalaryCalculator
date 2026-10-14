<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblDependants = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtDependants = New System.Windows.Forms.TextBox()
        Me.txtSchoolFees = New System.Windows.Forms.TextBox()
        Me.btnCalculateFees = New System.Windows.Forms.Button()
        Me.btnCalculateDeductions = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(295, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(117, 13)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Sam's Salary Calculator"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(12, 36)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(108, 13)
        Me.lblSalary.TabIndex = 1
        Me.lblSalary.Text = "Monthly Salary (UGX)"
        '
        'lblDependants
        '
        Me.lblDependants.AutoSize = True
        Me.lblDependants.Location = New System.Drawing.Point(12, 60)
        Me.lblDependants.Name = "lblDependants"
        Me.lblDependants.Size = New System.Drawing.Size(119, 13)
        Me.lblDependants.TabIndex = 2
        Me.lblDependants.Text = "Number Of Dependants"
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Location = New System.Drawing.Point(21, 87)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(172, 13)
        Me.lblFees.TabIndex = 3
        Me.lblFees.Text = "School Fees per Dependant (UGX)"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(21, 208)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(42, 13)
        Me.lblResults.TabIndex = 4
        Me.lblResults.Text = "Results"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(126, 33)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 5
        Me.txtSalary.Text = "2300000"
        '
        'txtDependants
        '
        Me.txtDependants.Location = New System.Drawing.Point(162, 57)
        Me.txtDependants.Name = "txtDependants"
        Me.txtDependants.Size = New System.Drawing.Size(100, 20)
        Me.txtDependants.TabIndex = 6
        Me.txtDependants.Text = "4"
        '
        'txtSchoolFees
        '
        Me.txtSchoolFees.Location = New System.Drawing.Point(199, 84)
        Me.txtSchoolFees.Name = "txtSchoolFees"
        Me.txtSchoolFees.Size = New System.Drawing.Size(100, 20)
        Me.txtSchoolFees.TabIndex = 7
        Me.txtSchoolFees.Text = "430000"
        '
        'btnCalculateFees
        '
        Me.btnCalculateFees.Location = New System.Drawing.Point(102, 110)
        Me.btnCalculateFees.Name = "btnCalculateFees"
        Me.btnCalculateFees.Size = New System.Drawing.Size(160, 23)
        Me.btnCalculateFees.TabIndex = 8
        Me.btnCalculateFees.Text = "Calculate School Fees"
        Me.btnCalculateFees.UseVisualStyleBackColor = True
        '
        'btnCalculateDeductions
        '
        Me.btnCalculateDeductions.Location = New System.Drawing.Point(478, 110)
        Me.btnCalculateDeductions.Name = "btnCalculateDeductions"
        Me.btnCalculateDeductions.Size = New System.Drawing.Size(167, 23)
        Me.btnCalculateDeductions.TabIndex = 9
        Me.btnCalculateDeductions.Text = "Calculate Salary Deductions"
        Me.btnCalculateDeductions.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(308, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(117, 201)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(100, 20)
        Me.txtResults.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateDeductions)
        Me.Controls.Add(Me.btnCalculateFees)
        Me.Controls.Add(Me.txtSchoolFees)
        Me.Controls.Add(Me.txtDependants)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblFees)
        Me.Controls.Add(Me.lblDependants)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblDependants As Label
    Friend WithEvents lblFees As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtDependants As TextBox
    Friend WithEvents txtSchoolFees As TextBox
    Friend WithEvents btnCalculateFees As Button
    Friend WithEvents btnCalculateDeductions As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtResults As TextBox
End Class

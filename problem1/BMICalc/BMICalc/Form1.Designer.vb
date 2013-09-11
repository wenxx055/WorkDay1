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
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.btnCalcBMI = New System.Windows.Forms.Button()
        Me.txtBMI = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(83, 22)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(88, 20)
        Me.txtWeight.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Weight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Height"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(270, 21)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(88, 20)
        Me.txtHeight.TabIndex = 2
        '
        'btnCalcBMI
        '
        Me.btnCalcBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcBMI.Location = New System.Drawing.Point(38, 59)
        Me.btnCalcBMI.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalcBMI.Name = "btnCalcBMI"
        Me.btnCalcBMI.Size = New System.Drawing.Size(362, 141)
        Me.btnCalcBMI.TabIndex = 4
        Me.btnCalcBMI.Text = "Calculate BMI"
        Me.btnCalcBMI.UseVisualStyleBackColor = True
        '
        'txtBMI
        '
        Me.txtBMI.AutoSize = True
        Me.txtBMI.Location = New System.Drawing.Point(145, 221)
        Me.txtBMI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.Size = New System.Drawing.Size(26, 13)
        Me.txtBMI.TabIndex = 6
        Me.txtBMI.Text = "BMI"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(178, 218)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "lbs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "inches"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 265)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCalcBMI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWeight)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "BMI Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcBMI As System.Windows.Forms.Button
    Friend WithEvents txtBMI As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

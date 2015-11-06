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
        Me.number1 = New System.Windows.Forms.TextBox()
        Me.Number2 = New System.Windows.Forms.TextBox()
        Me.sum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'number1
        '
        Me.number1.Location = New System.Drawing.Point(132, 64)
        Me.number1.Name = "number1"
        Me.number1.Size = New System.Drawing.Size(100, 20)
        Me.number1.TabIndex = 0
        '
        'Number2
        '
        Me.Number2.Location = New System.Drawing.Point(132, 117)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(100, 20)
        Me.Number2.TabIndex = 1
        '
        'sum
        '
        Me.sum.Location = New System.Drawing.Point(132, 173)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(100, 20)
        Me.sum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "num1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "num2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Addition"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(132, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Sub"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(229, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Div"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(310, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Mult"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 261)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.number1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents number1 As TextBox
    Friend WithEvents Number2 As TextBox
    Friend WithEvents sum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class

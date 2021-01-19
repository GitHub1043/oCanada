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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(15, 26)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(96, 30)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Line"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.Location = New System.Drawing.Point(15, 108)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(72, 16)
        Me.lblLine.TabIndex = 1
        Me.lblLine.Text = "O Canada!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Guess Which Line is Displayed"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(214, 277)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtGuess.TabIndex = 3
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(15, 358)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(96, 30)
        Me.btnGuess.TabIndex = 4
        Me.btnGuess.Text = "Check Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 441)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button

End Class

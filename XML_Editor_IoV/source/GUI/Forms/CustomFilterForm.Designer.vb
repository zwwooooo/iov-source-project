<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomFilterForm
    Inherits SimpleFormBase

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
        Me.FilterTextBox = New System.Windows.Forms.TextBox
        Me.myCancelButton = New System.Windows.Forms.Button
        Me.myOKButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'FilterTextBox
        '
        Me.FilterTextBox.Location = New System.Drawing.Point(1, 3)
        Me.FilterTextBox.Multiline = True
        Me.FilterTextBox.Name = "FilterTextBox"
        Me.FilterTextBox.Size = New System.Drawing.Size(250, 62)
        Me.FilterTextBox.TabIndex = 0
        '
        'myCancelButton
        '
        Me.myCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.myCancelButton.Location = New System.Drawing.Point(161, 71)
        Me.myCancelButton.Name = "myCancelButton"
        Me.myCancelButton.Size = New System.Drawing.Size(90, 24)
        Me.myCancelButton.TabIndex = 10
        Me.myCancelButton.Text = "Cancel"
        Me.myCancelButton.UseVisualStyleBackColor = True
        Me.myCancelButton.Visible = False
        '
        'myOKButton
        '
        Me.myOKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.myOKButton.Location = New System.Drawing.Point(65, 71)
        Me.myOKButton.Name = "myOKButton"
        Me.myOKButton.Size = New System.Drawing.Size(90, 24)
        Me.myOKButton.TabIndex = 9
        Me.myOKButton.Text = "OK"
        Me.myOKButton.UseVisualStyleBackColor = True
        Me.myOKButton.Visible = False
        '
        'CustomFilterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 97)
        Me.Controls.Add(Me.myCancelButton)
        Me.Controls.Add(Me.myOKButton)
        Me.Controls.Add(Me.FilterTextBox)
        Me.Name = "CustomFilterForm"
        Me.Text = "Enter Custom Filter"
        Me.Controls.SetChildIndex(Me.FilterTextBox, 0)
        Me.Controls.SetChildIndex(Me.myOKButton, 0)
        Me.Controls.SetChildIndex(Me.myCancelButton, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FilterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents myCancelButton As System.Windows.Forms.Button
    Friend WithEvents myOKButton As System.Windows.Forms.Button
End Class

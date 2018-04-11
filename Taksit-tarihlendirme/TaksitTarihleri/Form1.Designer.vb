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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FiyatTextBox = New System.Windows.Forms.TextBox()
        Me.TSayiTextBox = New System.Windows.Forms.TextBox()
        Me.TTarihTextBox = New System.Windows.Forms.TextBox()
        Me.TaksitlerListBox = New System.Windows.Forms.ListBox()
        Me.TaksitlendirButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ürün Fiyatı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Taksit Sayısı:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Taksit Başlangıç Tarihi:"
        '
        'FiyatTextBox
        '
        Me.FiyatTextBox.Location = New System.Drawing.Point(143, 17)
        Me.FiyatTextBox.Name = "FiyatTextBox"
        Me.FiyatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FiyatTextBox.TabIndex = 3
        '
        'TSayiTextBox
        '
        Me.TSayiTextBox.Location = New System.Drawing.Point(143, 43)
        Me.TSayiTextBox.Name = "TSayiTextBox"
        Me.TSayiTextBox.Size = New System.Drawing.Size(55, 20)
        Me.TSayiTextBox.TabIndex = 4
        '
        'TTarihTextBox
        '
        Me.TTarihTextBox.Location = New System.Drawing.Point(143, 69)
        Me.TTarihTextBox.Name = "TTarihTextBox"
        Me.TTarihTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TTarihTextBox.TabIndex = 5
        '
        'TaksitlerListBox
        '
        Me.TaksitlerListBox.FormattingEnabled = True
        Me.TaksitlerListBox.Location = New System.Drawing.Point(32, 95)
        Me.TaksitlerListBox.Name = "TaksitlerListBox"
        Me.TaksitlerListBox.Size = New System.Drawing.Size(211, 160)
        Me.TaksitlerListBox.TabIndex = 6
        '
        'TaksitlendirButton
        '
        Me.TaksitlendirButton.Location = New System.Drawing.Point(32, 261)
        Me.TaksitlendirButton.Name = "TaksitlendirButton"
        Me.TaksitlendirButton.Size = New System.Drawing.Size(211, 23)
        Me.TaksitlendirButton.TabIndex = 7
        Me.TaksitlendirButton.Text = "Taksitlendir"
        Me.TaksitlendirButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 311)
        Me.Controls.Add(Me.TaksitlendirButton)
        Me.Controls.Add(Me.TaksitlerListBox)
        Me.Controls.Add(Me.TTarihTextBox)
        Me.Controls.Add(Me.TSayiTextBox)
        Me.Controls.Add(Me.FiyatTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FiyatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TSayiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TTarihTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaksitlerListBox As System.Windows.Forms.ListBox
    Friend WithEvents TaksitlendirButton As System.Windows.Forms.Button

End Class

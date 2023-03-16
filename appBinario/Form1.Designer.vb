Namespace My
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
            Me.btnLeer = New System.Windows.Forms.Button()
            Me.btnEscribir = New System.Windows.Forms.Button()
            Me.btnBinario = New System.Windows.Forms.Button()
            Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.SuspendLayout()
            '
            'btnLeer
            '
            Me.btnLeer.Location = New System.Drawing.Point(109, 68)
            Me.btnLeer.Name = "btnLeer"
            Me.btnLeer.Size = New System.Drawing.Size(101, 40)
            Me.btnLeer.TabIndex = 0
            Me.btnLeer.Text = "LEER"
            Me.btnLeer.UseVisualStyleBackColor = True
            '
            'btnEscribir
            '
            Me.btnEscribir.Location = New System.Drawing.Point(343, 68)
            Me.btnEscribir.Name = "btnEscribir"
            Me.btnEscribir.Size = New System.Drawing.Size(98, 40)
            Me.btnEscribir.TabIndex = 1
            Me.btnEscribir.Text = "ESCRIBIR"
            Me.btnEscribir.UseVisualStyleBackColor = True
            '
            'btnBinario
            '
            Me.btnBinario.Location = New System.Drawing.Point(574, 68)
            Me.btnBinario.Name = "btnBinario"
            Me.btnBinario.Size = New System.Drawing.Size(126, 40)
            Me.btnBinario.TabIndex = 2
            Me.btnBinario.Text = "ESCRIBIR BINARIO"
            Me.btnBinario.UseVisualStyleBackColor = True
            '
            'RichTextBox1
            '
            Me.RichTextBox1.Location = New System.Drawing.Point(23, 150)
            Me.RichTextBox1.Name = "RichTextBox1"
            Me.RichTextBox1.Size = New System.Drawing.Size(750, 279)
            Me.RichTextBox1.TabIndex = 3
            Me.RichTextBox1.Text = ""
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.RichTextBox1)
            Me.Controls.Add(Me.btnBinario)
            Me.Controls.Add(Me.btnEscribir)
            Me.Controls.Add(Me.btnLeer)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents btnLeer As Button
        Friend WithEvents btnEscribir As Button
        Friend WithEvents btnBinario As Button
        Friend WithEvents RichTextBox1 As RichTextBox
    End Class
End Namespace

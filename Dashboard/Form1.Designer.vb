<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Lmen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter2 = New System.Diagnostics.PerformanceCounter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.lcpu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PerformanceCounter3 = New System.Diagnostics.PerformanceCounter()
        Me.ldescar = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PerformanceCounter4 = New System.Diagnostics.PerformanceCounter()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lenvi = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.nameip = New System.Windows.Forms.Label()
        Me.computer_name = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PerformanceCounter3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PerformanceCounter4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Lmen)
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 167)
        Me.Panel1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Gold
        Me.ProgressBar1.Location = New System.Drawing.Point(43, 138)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(541, 17)
        Me.ProgressBar1.TabIndex = 2
        '
        'Lmen
        '
        Me.Lmen.AutoSize = True
        Me.Lmen.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lmen.ForeColor = System.Drawing.Color.Gold
        Me.Lmen.Location = New System.Drawing.Point(29, 30)
        Me.Lmen.Name = "Lmen"
        Me.Lmen.Size = New System.Drawing.Size(87, 101)
        Me.Lmen.TabIndex = 0
        Me.Lmen.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(206, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Meroria consumida"
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Memoria"
        Me.PerformanceCounter1.CounterName = "% de bytes confirmados en uso"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PerformanceCounter2
        '
        Me.PerformanceCounter2.CategoryName = "Procesador"
        Me.PerformanceCounter2.CounterName = "% de tiempo de procesador"
        Me.PerformanceCounter2.InstanceName = "_Total"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.ProgressBar2)
        Me.Panel2.Controls.Add(Me.lcpu)
        Me.Panel2.Location = New System.Drawing.Point(660, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(611, 167)
        Me.Panel2.TabIndex = 2
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.Color.Gold
        Me.ProgressBar2.Location = New System.Drawing.Point(29, 138)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(541, 17)
        Me.ProgressBar2.TabIndex = 3
        '
        'lcpu
        '
        Me.lcpu.AutoSize = True
        Me.lcpu.Font = New System.Drawing.Font("Comic Sans MS", 36.0!)
        Me.lcpu.ForeColor = System.Drawing.Color.Gold
        Me.lcpu.Location = New System.Drawing.Point(27, 30)
        Me.lcpu.Name = "lcpu"
        Me.lcpu.Size = New System.Drawing.Size(87, 101)
        Me.lcpu.TabIndex = 0
        Me.lcpu.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(893, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CPU Consimida"
        '
        'PerformanceCounter3
        '
        Me.PerformanceCounter3.CategoryName = "Adaptador de red"
        Me.PerformanceCounter3.CounterName = "Conexiones RSC activas TCP"
        Me.PerformanceCounter3.InstanceName = "Intel[R] Dual Band Wireless-AC 7265"
        '
        'ldescar
        '
        Me.ldescar.AutoSize = True
        Me.ldescar.Font = New System.Drawing.Font("Comic Sans MS", 36.0!)
        Me.ldescar.ForeColor = System.Drawing.Color.Gold
        Me.ldescar.Location = New System.Drawing.Point(27, 39)
        Me.ldescar.Name = "ldescar"
        Me.ldescar.Size = New System.Drawing.Size(87, 101)
        Me.ldescar.TabIndex = 5
        Me.ldescar.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.Controls.Add(Me.ProgressBar3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ldescar)
        Me.Panel3.Location = New System.Drawing.Point(13, 308)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(614, 163)
        Me.Panel3.TabIndex = 6
        '
        'ProgressBar3
        '
        Me.ProgressBar3.BackColor = System.Drawing.Color.Gold
        Me.ProgressBar3.Location = New System.Drawing.Point(43, 135)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(541, 17)
        Me.ProgressBar3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(412, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 78)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mbps"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(117, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(305, 33)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Ancho de banda de Suvida"
        '
        'PerformanceCounter4
        '
        Me.PerformanceCounter4.CategoryName = "Adaptador de red"
        Me.PerformanceCounter4.CounterName = "Paquetes enviados/s"
        Me.PerformanceCounter4.InstanceName = "Intel[R] Dual Band Wireless-AC 7265"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Controls.Add(Me.ProgressBar4)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.lenvi)
        Me.Panel4.Location = New System.Drawing.Point(660, 305)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(614, 163)
        Me.Panel4.TabIndex = 8
        '
        'ProgressBar4
        '
        Me.ProgressBar4.BackColor = System.Drawing.Color.Gold
        Me.ProgressBar4.Location = New System.Drawing.Point(29, 126)
        Me.ProgressBar4.Maximum = 100000
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(541, 17)
        Me.ProgressBar4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(416, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 78)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mbps"
        '
        'lenvi
        '
        Me.lenvi.AutoSize = True
        Me.lenvi.Font = New System.Drawing.Font("Comic Sans MS", 36.0!)
        Me.lenvi.ForeColor = System.Drawing.Color.Gold
        Me.lenvi.Location = New System.Drawing.Point(27, 39)
        Me.lenvi.Name = "lenvi"
        Me.lenvi.Size = New System.Drawing.Size(87, 101)
        Me.lenvi.TabIndex = 5
        Me.lenvi.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(775, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(336, 33)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Ancho De banda Descargado "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Controls.Add(Me.nameip)
        Me.Panel5.Controls.Add(Me.computer_name)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(0, 670)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1296, 35)
        Me.Panel5.TabIndex = 10
        '
        'nameip
        '
        Me.nameip.AutoSize = True
        Me.nameip.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.nameip.ForeColor = System.Drawing.Color.White
        Me.nameip.Location = New System.Drawing.Point(1046, 5)
        Me.nameip.Name = "nameip"
        Me.nameip.Size = New System.Drawing.Size(24, 23)
        Me.nameip.TabIndex = 2
        Me.nameip.Text = "ip"
        '
        'computer_name
        '
        Me.computer_name.AutoSize = True
        Me.computer_name.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computer_name.ForeColor = System.Drawing.Color.White
        Me.computer_name.Location = New System.Drawing.Point(9, 5)
        Me.computer_name.Name = "computer_name"
        Me.computer_name.Size = New System.Drawing.Size(117, 23)
        Me.computer_name.TabIndex = 1
        Me.computer_name.Text = "computer name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1297, 706)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PerformanceCounter3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PerformanceCounter4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lmen As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PerformanceCounter2 As PerformanceCounter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lcpu As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PerformanceCounter3 As PerformanceCounter
    Friend WithEvents ldescar As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lenvi As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents Panel5 As Panel
    Friend WithEvents computer_name As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nameip As Label
    Friend WithEvents PerformanceCounter4 As PerformanceCounter
End Class

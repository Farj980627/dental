﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bntDiario = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.btnBuscarFechas = New System.Windows.Forms.Button()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 360)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1286, 249)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(646, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 118)
        Me.Panel1.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(343, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(0, 31)
        Me.lblTotal.TabIndex = 47
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(236, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(80, 31)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Total:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(121, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(335, 30)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Text = "NOMBRE PRODUCTO"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.bntDiario)
        Me.Panel2.Controls.Add(Me.btnMostrar)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 118)
        Me.Panel2.TabIndex = 4
        '
        'bntDiario
        '
        Me.bntDiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bntDiario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bntDiario.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntDiario.ForeColor = System.Drawing.Color.White
        Me.bntDiario.Location = New System.Drawing.Point(0, 64)
        Me.bntDiario.Name = "bntDiario"
        Me.bntDiario.Size = New System.Drawing.Size(637, 54)
        Me.bntDiario.TabIndex = 6
        Me.bntDiario.Text = "Reporte Diario"
        Me.bntDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bntDiario.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnMostrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMostrar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.White
        Me.btnMostrar.Location = New System.Drawing.Point(0, 0)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(637, 76)
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Mostrar Todo"
        Me.btnMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtNombre)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(646, 127)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(637, 119)
        Me.Panel4.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.cbTipo)
        Me.Panel5.Controls.Add(Me.btnBuscarFechas)
        Me.Panel5.Controls.Add(Me.dtpFin)
        Me.Panel5.Controls.Add(Me.dtpInicio)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 127)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(637, 119)
        Me.Panel5.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(144, 31)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "USUARIOS:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbTipo
        '
        Me.cbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.cbTipo.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.ForeColor = System.Drawing.Color.White
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Todos Los Pagos", "Efectivo", "Electrónico"})
        Me.cbTipo.Location = New System.Drawing.Point(9, 81)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(229, 38)
        Me.cbTipo.TabIndex = 8
        '
        'btnBuscarFechas
        '
        Me.btnBuscarFechas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarFechas.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnBuscarFechas.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFechas.ForeColor = System.Drawing.Color.White
        Me.btnBuscarFechas.Location = New System.Drawing.Point(296, 58)
        Me.btnBuscarFechas.Name = "btnBuscarFechas"
        Me.btnBuscarFechas.Size = New System.Drawing.Size(283, 57)
        Me.btnBuscarFechas.TabIndex = 7
        Me.btnBuscarFechas.Text = "Buscar "
        Me.btnBuscarFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarFechas.UseVisualStyleBackColor = False
        '
        'dtpFin
        '
        Me.dtpFin.CalendarFont = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dtpFin.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(296, 3)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(185, 37)
        Me.dtpFin.TabIndex = 1
        Me.dtpFin.Value = New Date(2019, 3, 20, 0, 0, 0, 0)
        '
        'dtpInicio
        '
        Me.dtpInicio.CalendarFont = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dtpInicio.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(9, 3)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(181, 37)
        Me.dtpInicio.TabIndex = 0
        Me.dtpInicio.Value = New Date(2019, 3, 20, 0, 0, 0, 0)
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = False
        Me.dgvProducto.AllowUserToDeleteRows = False
        Me.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.dgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducto.Location = New System.Drawing.Point(0, 0)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.RowHeadersVisible = False
        Me.dgvProducto.RowHeadersWidth = 51
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.dgvProducto.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.Size = New System.Drawing.Size(1286, 360)
        Me.dgvProducto.TabIndex = 9
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1286, 609)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bntDiario As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents btnBuscarFechas As Button
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents dgvProducto As DataGridView
End Class

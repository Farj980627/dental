<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.dataBusProductos = New System.Windows.Forms.DataGridView()
        Me.btnFavorito5 = New System.Windows.Forms.Button()
        Me.btnFavorito4 = New System.Windows.Forms.Button()
        Me.btnFavorito3 = New System.Windows.Forms.Button()
        Me.btnFavorito2 = New System.Windows.Forms.Button()
        Me.btnFavorito1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnFavorito15 = New System.Windows.Forms.Button()
        Me.btnFavorito14 = New System.Windows.Forms.Button()
        Me.btnFavorito13 = New System.Windows.Forms.Button()
        Me.btnFavorito12 = New System.Windows.Forms.Button()
        Me.btnFavorito11 = New System.Windows.Forms.Button()
        Me.btnFavorito10 = New System.Windows.Forms.Button()
        Me.btnFavorito9 = New System.Windows.Forms.Button()
        Me.btnFavorito8 = New System.Windows.Forms.Button()
        Me.btnFavorito7 = New System.Windows.Forms.Button()
        Me.btnFavorito6 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataBusProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1201, 63)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Location = New System.Drawing.Point(603, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 57)
        Me.Panel1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(47, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(130, 31)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "CODIGO  "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(183, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(403, 30)
        Me.txtCodigo.TabIndex = 10
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtProducto)
        Me.Panel4.Controls.Add(Me.txtCantidad)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(594, 57)
        Me.Panel4.TabIndex = 11
        '
        'txtProducto
        '
        Me.txtProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducto.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.ForeColor = System.Drawing.Color.White
        Me.txtProducto.Location = New System.Drawing.Point(189, 23)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(402, 30)
        Me.txtProducto.TabIndex = 90
        Me.txtProducto.Text = "PRODUCTOS"
        Me.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(85, 23)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(83, 30)
        Me.txtCantidad.TabIndex = 15
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CANT  "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 551)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1201, 58)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnConfirmar)
        Me.Panel2.Location = New System.Drawing.Point(603, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 52)
        Me.Panel2.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(0, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(230, 47)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnConfirmar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.White
        Me.btnConfirmar.Location = New System.Drawing.Point(297, 5)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(230, 47)
        Me.btnConfirmar.TabIndex = 13
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblTotal)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(524, 52)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(411, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(26, 31)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "$"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(443, 11)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(31, 31)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(305, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(100, 31)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "TOTAL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvProducto
        '
        Me.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Location = New System.Drawing.Point(0, 335)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducto.RowHeadersVisible = False
        Me.dgvProducto.RowHeadersWidth = 51
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.dgvProducto.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.Size = New System.Drawing.Size(1201, 218)
        Me.dgvProducto.TabIndex = 3
        '
        'dataBusProductos
        '
        Me.dataBusProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataBusProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dataBusProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataBusProductos.Location = New System.Drawing.Point(3, 357)
        Me.dataBusProductos.Name = "dataBusProductos"
        Me.dataBusProductos.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.dataBusProductos.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dataBusProductos.RowTemplate.Height = 24
        Me.dataBusProductos.Size = New System.Drawing.Size(1198, 181)
        Me.dataBusProductos.TabIndex = 4
        Me.dataBusProductos.Visible = False
        '
        'btnFavorito5
        '
        Me.btnFavorito5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito5.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito5.ForeColor = System.Drawing.Color.White
        Me.btnFavorito5.Location = New System.Drawing.Point(959, 3)
        Me.btnFavorito5.Name = "btnFavorito5"
        Me.btnFavorito5.Size = New System.Drawing.Size(236, 84)
        Me.btnFavorito5.TabIndex = 18
        Me.btnFavorito5.Text = "Producto5"
        Me.btnFavorito5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito5.UseVisualStyleBackColor = False
        '
        'btnFavorito4
        '
        Me.btnFavorito4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito4.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito4.ForeColor = System.Drawing.Color.White
        Me.btnFavorito4.Location = New System.Drawing.Point(720, 3)
        Me.btnFavorito4.Name = "btnFavorito4"
        Me.btnFavorito4.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito4.TabIndex = 17
        Me.btnFavorito4.Text = "Producto4"
        Me.btnFavorito4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito4.UseVisualStyleBackColor = False
        '
        'btnFavorito3
        '
        Me.btnFavorito3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito3.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito3.ForeColor = System.Drawing.Color.White
        Me.btnFavorito3.Location = New System.Drawing.Point(481, 3)
        Me.btnFavorito3.Name = "btnFavorito3"
        Me.btnFavorito3.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito3.TabIndex = 16
        Me.btnFavorito3.Text = "Producto3"
        Me.btnFavorito3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito3.UseVisualStyleBackColor = False
        '
        'btnFavorito2
        '
        Me.btnFavorito2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito2.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito2.ForeColor = System.Drawing.Color.White
        Me.btnFavorito2.Location = New System.Drawing.Point(242, 3)
        Me.btnFavorito2.Name = "btnFavorito2"
        Me.btnFavorito2.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito2.TabIndex = 15
        Me.btnFavorito2.Text = "Producto2"
        Me.btnFavorito2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito2.UseVisualStyleBackColor = False
        '
        'btnFavorito1
        '
        Me.btnFavorito1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito1.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito1.ForeColor = System.Drawing.Color.White
        Me.btnFavorito1.Location = New System.Drawing.Point(3, 3)
        Me.btnFavorito1.Name = "btnFavorito1"
        Me.btnFavorito1.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito1.TabIndex = 14
        Me.btnFavorito1.Text = "Producto1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFavorito1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito1.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito15, 4, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito14, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito13, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito12, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito11, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito10, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito9, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito8, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito7, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito6, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito5, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito4, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnFavorito3, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 62)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1198, 270)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'btnFavorito15
        '
        Me.btnFavorito15.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito15.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito15.ForeColor = System.Drawing.Color.White
        Me.btnFavorito15.Location = New System.Drawing.Point(959, 183)
        Me.btnFavorito15.Name = "btnFavorito15"
        Me.btnFavorito15.Size = New System.Drawing.Size(236, 84)
        Me.btnFavorito15.TabIndex = 28
        Me.btnFavorito15.Text = "Producto15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFavorito15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito15.UseVisualStyleBackColor = False
        '
        'btnFavorito14
        '
        Me.btnFavorito14.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito14.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito14.ForeColor = System.Drawing.Color.White
        Me.btnFavorito14.Location = New System.Drawing.Point(720, 183)
        Me.btnFavorito14.Name = "btnFavorito14"
        Me.btnFavorito14.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito14.TabIndex = 27
        Me.btnFavorito14.Text = "Producto14" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFavorito14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito14.UseVisualStyleBackColor = False
        '
        'btnFavorito13
        '
        Me.btnFavorito13.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito13.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito13.ForeColor = System.Drawing.Color.White
        Me.btnFavorito13.Location = New System.Drawing.Point(481, 183)
        Me.btnFavorito13.Name = "btnFavorito13"
        Me.btnFavorito13.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito13.TabIndex = 26
        Me.btnFavorito13.Text = "Producto1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3"
        Me.btnFavorito13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito13.UseVisualStyleBackColor = False
        '
        'btnFavorito12
        '
        Me.btnFavorito12.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito12.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito12.ForeColor = System.Drawing.Color.White
        Me.btnFavorito12.Location = New System.Drawing.Point(242, 183)
        Me.btnFavorito12.Name = "btnFavorito12"
        Me.btnFavorito12.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito12.TabIndex = 25
        Me.btnFavorito12.Text = "Producto12" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFavorito12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito12.UseVisualStyleBackColor = False
        '
        'btnFavorito11
        '
        Me.btnFavorito11.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito11.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito11.ForeColor = System.Drawing.Color.White
        Me.btnFavorito11.Location = New System.Drawing.Point(3, 183)
        Me.btnFavorito11.Name = "btnFavorito11"
        Me.btnFavorito11.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito11.TabIndex = 24
        Me.btnFavorito11.Text = "Producto1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1"
        Me.btnFavorito11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito11.UseVisualStyleBackColor = False
        '
        'btnFavorito10
        '
        Me.btnFavorito10.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito10.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito10.ForeColor = System.Drawing.Color.White
        Me.btnFavorito10.Location = New System.Drawing.Point(959, 93)
        Me.btnFavorito10.Name = "btnFavorito10"
        Me.btnFavorito10.Size = New System.Drawing.Size(236, 84)
        Me.btnFavorito10.TabIndex = 23
        Me.btnFavorito10.Text = "Producto1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.btnFavorito10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito10.UseVisualStyleBackColor = False
        '
        'btnFavorito9
        '
        Me.btnFavorito9.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito9.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito9.ForeColor = System.Drawing.Color.White
        Me.btnFavorito9.Location = New System.Drawing.Point(720, 93)
        Me.btnFavorito9.Name = "btnFavorito9"
        Me.btnFavorito9.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito9.TabIndex = 22
        Me.btnFavorito9.Text = "Producto9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnFavorito9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito9.UseVisualStyleBackColor = False
        '
        'btnFavorito8
        '
        Me.btnFavorito8.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito8.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito8.ForeColor = System.Drawing.Color.White
        Me.btnFavorito8.Location = New System.Drawing.Point(481, 93)
        Me.btnFavorito8.Name = "btnFavorito8"
        Me.btnFavorito8.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito8.TabIndex = 21
        Me.btnFavorito8.Text = "Producto8"
        Me.btnFavorito8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito8.UseVisualStyleBackColor = False
        '
        'btnFavorito7
        '
        Me.btnFavorito7.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito7.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito7.ForeColor = System.Drawing.Color.White
        Me.btnFavorito7.Location = New System.Drawing.Point(242, 93)
        Me.btnFavorito7.Name = "btnFavorito7"
        Me.btnFavorito7.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito7.TabIndex = 20
        Me.btnFavorito7.Text = "Producto7"
        Me.btnFavorito7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito7.UseVisualStyleBackColor = False
        '
        'btnFavorito6
        '
        Me.btnFavorito6.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnFavorito6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFavorito6.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFavorito6.ForeColor = System.Drawing.Color.White
        Me.btnFavorito6.Location = New System.Drawing.Point(3, 93)
        Me.btnFavorito6.Name = "btnFavorito6"
        Me.btnFavorito6.Size = New System.Drawing.Size(233, 84)
        Me.btnFavorito6.TabIndex = 19
        Me.btnFavorito6.Text = "Producto6"
        Me.btnFavorito6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFavorito6.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1201, 609)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.dataBusProductos)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataBusProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvProducto As DataGridView
    Friend WithEvents dataBusProductos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFavorito5 As Button
    Friend WithEvents btnFavorito4 As Button
    Friend WithEvents btnFavorito3 As Button
    Friend WithEvents btnFavorito2 As Button
    Friend WithEvents btnFavorito1 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnFavorito15 As Button
    Friend WithEvents btnFavorito14 As Button
    Friend WithEvents btnFavorito13 As Button
    Friend WithEvents btnFavorito12 As Button
    Friend WithEvents btnFavorito11 As Button
    Friend WithEvents btnFavorito10 As Button
    Friend WithEvents btnFavorito9 As Button
    Friend WithEvents btnFavorito8 As Button
    Friend WithEvents btnFavorito7 As Button
    Friend WithEvents btnFavorito6 As Button
End Class

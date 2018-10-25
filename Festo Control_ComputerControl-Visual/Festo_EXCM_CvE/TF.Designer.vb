<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TF))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSL_OnOffline = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LB_Commands = New System.Windows.Forms.ListBox()
        Me.TB_Trick = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TB_ProgramName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyConnectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB_Connector = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LAB_Manufacturer = New System.Windows.Forms.Label()
        Me.BUTT_CopyConnector = New System.Windows.Forms.Button()
        Me.BUTT_ClearConnector = New System.Windows.Forms.Button()
        Me.BUTT_ClearTray = New System.Windows.Forms.Button()
        Me.Panel_Insert_1_3 = New System.Windows.Forms.Panel()
        Me.RB_Insert_1_3 = New System.Windows.Forms.RadioButton()
        Me.Panel_Insert_1_4 = New System.Windows.Forms.Panel()
        Me.RB_Insert_1_4 = New System.Windows.Forms.RadioButton()
        Me.Panel_Insert_1_1 = New System.Windows.Forms.Panel()
        Me.RB_Insert_1_1 = New System.Windows.Forms.RadioButton()
        Me.Panel_Insert_1_2 = New System.Windows.Forms.Panel()
        Me.RB_Insert_1_2 = New System.Windows.Forms.RadioButton()
        Me.GB_FirstInsert = New System.Windows.Forms.GroupBox()
        Me.GB_SecondInsert = New System.Windows.Forms.GroupBox()
        Me.Panel_2_NONE = New System.Windows.Forms.Panel()
        Me.RB_Insert_2_NONE = New System.Windows.Forms.RadioButton()
        Me.Panel_Insert_2_1 = New System.Windows.Forms.Panel()
        Me.RB_Insert_2_1 = New System.Windows.Forms.RadioButton()
        Me.Panel_Insert_2_3 = New System.Windows.Forms.Panel()
        Me.RB_Insert_2_3 = New System.Windows.Forms.RadioButton()
        Me.Panel_Insert_2_2 = New System.Windows.Forms.Panel()
        Me.RB_Insert_2_2 = New System.Windows.Forms.RadioButton()
        Me.Panel_Insert_2_4 = New System.Windows.Forms.Panel()
        Me.RB_Insert_2_4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LAB_PartNumber = New System.Windows.Forms.Label()
        Me.BUTT_ProgramRun = New System.Windows.Forms.Button()
        Me.BUTT_ProgramStop = New System.Windows.Forms.Button()
        Me.BUTT_ProgramPause = New System.Windows.Forms.Button()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.LAB_RunState = New System.Windows.Forms.Label()
        Me.BUTT_Conn4 = New Festo_EXCM_CvE.RoundButton()
        Me.BUTT_Conn3 = New Festo_EXCM_CvE.RoundButton()
        Me.BUTT_Conn2 = New Festo_EXCM_CvE.RoundButton()
        Me.BUTT_Conn1 = New Festo_EXCM_CvE.RoundButton()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PB_Connector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel_Insert_1_3.SuspendLayout()
        Me.Panel_Insert_1_4.SuspendLayout()
        Me.Panel_Insert_1_1.SuspendLayout()
        Me.Panel_Insert_1_2.SuspendLayout()
        Me.GB_FirstInsert.SuspendLayout()
        Me.GB_SecondInsert.SuspendLayout()
        Me.Panel_2_NONE.SuspendLayout()
        Me.Panel_Insert_2_1.SuspendLayout()
        Me.Panel_Insert_2_3.SuspendLayout()
        Me.Panel_Insert_2_2.SuspendLayout()
        Me.Panel_Insert_2_4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_OnOffline})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 707)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1094, 22)
        Me.StatusStrip1.TabIndex = 31
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSL_OnOffline
        '
        Me.TSSL_OnOffline.Name = "TSSL_OnOffline"
        Me.TSSL_OnOffline.Size = New System.Drawing.Size(41, 17)
        Me.TSSL_OnOffline.Text = "offline"
        '
        'LB_Commands
        '
        Me.LB_Commands.FormattingEnabled = True
        Me.LB_Commands.Location = New System.Drawing.Point(844, 186)
        Me.LB_Commands.Name = "LB_Commands"
        Me.LB_Commands.Size = New System.Drawing.Size(238, 511)
        Me.LB_Commands.TabIndex = 38
        Me.LB_Commands.TabStop = False
        '
        'TB_Trick
        '
        Me.TB_Trick.Location = New System.Drawing.Point(889, 385)
        Me.TB_Trick.Name = "TB_Trick"
        Me.TB_Trick.Size = New System.Drawing.Size(29, 20)
        Me.TB_Trick.TabIndex = 42
        Me.TB_Trick.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'TB_ProgramName
        '
        Me.TB_ProgramName.Location = New System.Drawing.Point(238, 43)
        Me.TB_ProgramName.MaxLength = 100
        Me.TB_ProgramName.Name = "TB_ProgramName"
        Me.TB_ProgramName.Size = New System.Drawing.Size(270, 20)
        Me.TB_ProgramName.TabIndex = 53
        Me.TB_ProgramName.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Program Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SetupToolStripMenuItem, Me.DirectControlToolStripMenuItem, Me.InstructionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1094, 24)
        Me.MenuStrip1.TabIndex = 61
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProgramToolStripMenuItem, Me.LoadProgramToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.TrayToolStripMenuItem, Me.ConnectorToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewProgramToolStripMenuItem
        '
        Me.NewProgramToolStripMenuItem.Name = "NewProgramToolStripMenuItem"
        Me.NewProgramToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewProgramToolStripMenuItem.Text = "New Program"
        '
        'LoadProgramToolStripMenuItem
        '
        Me.LoadProgramToolStripMenuItem.Name = "LoadProgramToolStripMenuItem"
        Me.LoadProgramToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoadProgramToolStripMenuItem.Text = "Open Program"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'TrayToolStripMenuItem
        '
        Me.TrayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTrayToolStripMenuItem, Me.OpenTrayToolStripMenuItem, Me.ModifyTrayToolStripMenuItem})
        Me.TrayToolStripMenuItem.Name = "TrayToolStripMenuItem"
        Me.TrayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TrayToolStripMenuItem.Text = "Tray"
        '
        'NewTrayToolStripMenuItem
        '
        Me.NewTrayToolStripMenuItem.Name = "NewTrayToolStripMenuItem"
        Me.NewTrayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewTrayToolStripMenuItem.Text = "New Tray"
        '
        'OpenTrayToolStripMenuItem
        '
        Me.OpenTrayToolStripMenuItem.Name = "OpenTrayToolStripMenuItem"
        Me.OpenTrayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenTrayToolStripMenuItem.Text = "Open Tray"
        '
        'ModifyTrayToolStripMenuItem
        '
        Me.ModifyTrayToolStripMenuItem.Name = "ModifyTrayToolStripMenuItem"
        Me.ModifyTrayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModifyTrayToolStripMenuItem.Text = "Modify Tray"
        '
        'ConnectorToolStripMenuItem
        '
        Me.ConnectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConnectorToolStripMenuItem, Me.ModifyConnectorToolStripMenuItem})
        Me.ConnectorToolStripMenuItem.Name = "ConnectorToolStripMenuItem"
        Me.ConnectorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectorToolStripMenuItem.Text = "Connector"
        '
        'NewConnectorToolStripMenuItem
        '
        Me.NewConnectorToolStripMenuItem.Name = "NewConnectorToolStripMenuItem"
        Me.NewConnectorToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.NewConnectorToolStripMenuItem.Text = "New Connector"
        '
        'ModifyConnectorToolStripMenuItem
        '
        Me.ModifyConnectorToolStripMenuItem.Name = "ModifyConnectorToolStripMenuItem"
        Me.ModifyConnectorToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ModifyConnectorToolStripMenuItem.Text = "Modify Connector"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'DirectControlToolStripMenuItem
        '
        Me.DirectControlToolStripMenuItem.Name = "DirectControlToolStripMenuItem"
        Me.DirectControlToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.DirectControlToolStripMenuItem.Text = "Direct Control"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'PB_Connector
        '
        Me.PB_Connector.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB_Connector.InitialImage = Nothing
        Me.PB_Connector.Location = New System.Drawing.Point(238, 95)
        Me.PB_Connector.Name = "PB_Connector"
        Me.PB_Connector.Size = New System.Drawing.Size(600, 600)
        Me.PB_Connector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Connector.TabIndex = 66
        Me.PB_Connector.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BUTT_Conn4)
        Me.Panel1.Controls.Add(Me.BUTT_Conn3)
        Me.Panel1.Controls.Add(Me.BUTT_Conn2)
        Me.Panel1.Controls.Add(Me.BUTT_Conn1)
        Me.Panel1.Location = New System.Drawing.Point(12, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 220)
        Me.Panel1.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Tray"
        '
        'LAB_Manufacturer
        '
        Me.LAB_Manufacturer.AutoSize = True
        Me.LAB_Manufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_Manufacturer.Location = New System.Drawing.Point(235, 66)
        Me.LAB_Manufacturer.Name = "LAB_Manufacturer"
        Me.LAB_Manufacturer.Size = New System.Drawing.Size(131, 13)
        Me.LAB_Manufacturer.TabIndex = 70
        Me.LAB_Manufacturer.Text = "Manufacturer: MANNAME"
        '
        'BUTT_CopyConnector
        '
        Me.BUTT_CopyConnector.Location = New System.Drawing.Point(12, 387)
        Me.BUTT_CopyConnector.Name = "BUTT_CopyConnector"
        Me.BUTT_CopyConnector.Size = New System.Drawing.Size(100, 23)
        Me.BUTT_CopyConnector.TabIndex = 83
        Me.BUTT_CopyConnector.Text = "Copy Connector"
        Me.BUTT_CopyConnector.UseVisualStyleBackColor = True
        '
        'BUTT_ClearConnector
        '
        Me.BUTT_ClearConnector.Location = New System.Drawing.Point(12, 416)
        Me.BUTT_ClearConnector.Name = "BUTT_ClearConnector"
        Me.BUTT_ClearConnector.Size = New System.Drawing.Size(100, 23)
        Me.BUTT_ClearConnector.TabIndex = 84
        Me.BUTT_ClearConnector.Text = "Clear Connector"
        Me.BUTT_ClearConnector.UseVisualStyleBackColor = True
        '
        'BUTT_ClearTray
        '
        Me.BUTT_ClearTray.Location = New System.Drawing.Point(118, 416)
        Me.BUTT_ClearTray.Name = "BUTT_ClearTray"
        Me.BUTT_ClearTray.Size = New System.Drawing.Size(100, 23)
        Me.BUTT_ClearTray.TabIndex = 85
        Me.BUTT_ClearTray.Text = "Clear Tray"
        Me.BUTT_ClearTray.UseVisualStyleBackColor = True
        '
        'Panel_Insert_1_3
        '
        Me.Panel_Insert_1_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_1_3.Controls.Add(Me.RB_Insert_1_3)
        Me.Panel_Insert_1_3.Location = New System.Drawing.Point(6, 50)
        Me.Panel_Insert_1_3.Name = "Panel_Insert_1_3"
        Me.Panel_Insert_1_3.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_1_3.TabIndex = 86
        '
        'RB_Insert_1_3
        '
        Me.RB_Insert_1_3.AutoSize = True
        Me.RB_Insert_1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_1_3.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_1_3.Name = "RB_Insert_1_3"
        Me.RB_Insert_1_3.Size = New System.Drawing.Size(82, 20)
        Me.RB_Insert_1_3.TabIndex = 75
        Me.RB_Insert_1_3.TabStop = True
        Me.RB_Insert_1_3.Text = "Left/Right"
        Me.RB_Insert_1_3.UseVisualStyleBackColor = True
        '
        'Panel_Insert_1_4
        '
        Me.Panel_Insert_1_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_1_4.Controls.Add(Me.RB_Insert_1_4)
        Me.Panel_Insert_1_4.Location = New System.Drawing.Point(112, 50)
        Me.Panel_Insert_1_4.Name = "Panel_Insert_1_4"
        Me.Panel_Insert_1_4.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_1_4.TabIndex = 85
        '
        'RB_Insert_1_4
        '
        Me.RB_Insert_1_4.AutoSize = True
        Me.RB_Insert_1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_1_4.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_1_4.Name = "RB_Insert_1_4"
        Me.RB_Insert_1_4.Size = New System.Drawing.Size(82, 20)
        Me.RB_Insert_1_4.TabIndex = 75
        Me.RB_Insert_1_4.Text = "Right/Left"
        Me.RB_Insert_1_4.UseVisualStyleBackColor = True
        '
        'Panel_Insert_1_1
        '
        Me.Panel_Insert_1_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_1_1.Controls.Add(Me.RB_Insert_1_1)
        Me.Panel_Insert_1_1.Location = New System.Drawing.Point(6, 19)
        Me.Panel_Insert_1_1.Name = "Panel_Insert_1_1"
        Me.Panel_Insert_1_1.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_1_1.TabIndex = 84
        '
        'RB_Insert_1_1
        '
        Me.RB_Insert_1_1.AutoSize = True
        Me.RB_Insert_1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_1_1.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_1_1.Name = "RB_Insert_1_1"
        Me.RB_Insert_1_1.Size = New System.Drawing.Size(82, 20)
        Me.RB_Insert_1_1.TabIndex = 75
        Me.RB_Insert_1_1.TabStop = True
        Me.RB_Insert_1_1.Text = "Left Insert"
        Me.RB_Insert_1_1.UseVisualStyleBackColor = True
        '
        'Panel_Insert_1_2
        '
        Me.Panel_Insert_1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_1_2.Controls.Add(Me.RB_Insert_1_2)
        Me.Panel_Insert_1_2.Location = New System.Drawing.Point(112, 19)
        Me.Panel_Insert_1_2.Name = "Panel_Insert_1_2"
        Me.Panel_Insert_1_2.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_1_2.TabIndex = 83
        '
        'RB_Insert_1_2
        '
        Me.RB_Insert_1_2.AutoSize = True
        Me.RB_Insert_1_2.Checked = True
        Me.RB_Insert_1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_1_2.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_1_2.Name = "RB_Insert_1_2"
        Me.RB_Insert_1_2.Size = New System.Drawing.Size(92, 20)
        Me.RB_Insert_1_2.TabIndex = 75
        Me.RB_Insert_1_2.TabStop = True
        Me.RB_Insert_1_2.Text = "Right Insert"
        Me.RB_Insert_1_2.UseVisualStyleBackColor = True
        '
        'GB_FirstInsert
        '
        Me.GB_FirstInsert.Controls.Add(Me.Panel_Insert_1_1)
        Me.GB_FirstInsert.Controls.Add(Me.Panel_Insert_1_3)
        Me.GB_FirstInsert.Controls.Add(Me.Panel_Insert_1_2)
        Me.GB_FirstInsert.Controls.Add(Me.Panel_Insert_1_4)
        Me.GB_FirstInsert.Location = New System.Drawing.Point(12, 488)
        Me.GB_FirstInsert.Name = "GB_FirstInsert"
        Me.GB_FirstInsert.Size = New System.Drawing.Size(220, 85)
        Me.GB_FirstInsert.TabIndex = 87
        Me.GB_FirstInsert.TabStop = False
        Me.GB_FirstInsert.Text = "First Insert"
        '
        'GB_SecondInsert
        '
        Me.GB_SecondInsert.Controls.Add(Me.Panel_2_NONE)
        Me.GB_SecondInsert.Controls.Add(Me.Panel_Insert_2_1)
        Me.GB_SecondInsert.Controls.Add(Me.Panel_Insert_2_3)
        Me.GB_SecondInsert.Controls.Add(Me.Panel_Insert_2_2)
        Me.GB_SecondInsert.Controls.Add(Me.Panel_Insert_2_4)
        Me.GB_SecondInsert.Location = New System.Drawing.Point(12, 579)
        Me.GB_SecondInsert.Name = "GB_SecondInsert"
        Me.GB_SecondInsert.Size = New System.Drawing.Size(220, 116)
        Me.GB_SecondInsert.TabIndex = 88
        Me.GB_SecondInsert.TabStop = False
        Me.GB_SecondInsert.Text = "Second Insert"
        '
        'Panel_2_NONE
        '
        Me.Panel_2_NONE.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_2_NONE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_2_NONE.Controls.Add(Me.RB_Insert_2_NONE)
        Me.Panel_2_NONE.Location = New System.Drawing.Point(5, 81)
        Me.Panel_2_NONE.Name = "Panel_2_NONE"
        Me.Panel_2_NONE.Size = New System.Drawing.Size(100, 28)
        Me.Panel_2_NONE.TabIndex = 89
        '
        'RB_Insert_2_NONE
        '
        Me.RB_Insert_2_NONE.AutoSize = True
        Me.RB_Insert_2_NONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_2_NONE.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_2_NONE.Name = "RB_Insert_2_NONE"
        Me.RB_Insert_2_NONE.Size = New System.Drawing.Size(59, 20)
        Me.RB_Insert_2_NONE.TabIndex = 75
        Me.RB_Insert_2_NONE.TabStop = True
        Me.RB_Insert_2_NONE.Text = "None"
        Me.RB_Insert_2_NONE.UseVisualStyleBackColor = True
        '
        'Panel_Insert_2_1
        '
        Me.Panel_Insert_2_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_2_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_2_1.Controls.Add(Me.RB_Insert_2_1)
        Me.Panel_Insert_2_1.Location = New System.Drawing.Point(6, 19)
        Me.Panel_Insert_2_1.Name = "Panel_Insert_2_1"
        Me.Panel_Insert_2_1.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_2_1.TabIndex = 84
        '
        'RB_Insert_2_1
        '
        Me.RB_Insert_2_1.AutoSize = True
        Me.RB_Insert_2_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_2_1.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_2_1.Name = "RB_Insert_2_1"
        Me.RB_Insert_2_1.Size = New System.Drawing.Size(82, 20)
        Me.RB_Insert_2_1.TabIndex = 75
        Me.RB_Insert_2_1.TabStop = True
        Me.RB_Insert_2_1.Text = "Left Insert"
        Me.RB_Insert_2_1.UseVisualStyleBackColor = True
        '
        'Panel_Insert_2_3
        '
        Me.Panel_Insert_2_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_2_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_2_3.Controls.Add(Me.RB_Insert_2_3)
        Me.Panel_Insert_2_3.Location = New System.Drawing.Point(6, 50)
        Me.Panel_Insert_2_3.Name = "Panel_Insert_2_3"
        Me.Panel_Insert_2_3.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_2_3.TabIndex = 86
        '
        'RB_Insert_2_3
        '
        Me.RB_Insert_2_3.AutoSize = True
        Me.RB_Insert_2_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_2_3.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_2_3.Name = "RB_Insert_2_3"
        Me.RB_Insert_2_3.Size = New System.Drawing.Size(82, 20)
        Me.RB_Insert_2_3.TabIndex = 75
        Me.RB_Insert_2_3.TabStop = True
        Me.RB_Insert_2_3.Text = "Left/Right"
        Me.RB_Insert_2_3.UseVisualStyleBackColor = True
        '
        'Panel_Insert_2_2
        '
        Me.Panel_Insert_2_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_2_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_2_2.Controls.Add(Me.RB_Insert_2_2)
        Me.Panel_Insert_2_2.Location = New System.Drawing.Point(112, 19)
        Me.Panel_Insert_2_2.Name = "Panel_Insert_2_2"
        Me.Panel_Insert_2_2.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_2_2.TabIndex = 83
        '
        'RB_Insert_2_2
        '
        Me.RB_Insert_2_2.AutoSize = True
        Me.RB_Insert_2_2.Checked = True
        Me.RB_Insert_2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_2_2.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_2_2.Name = "RB_Insert_2_2"
        Me.RB_Insert_2_2.Size = New System.Drawing.Size(92, 20)
        Me.RB_Insert_2_2.TabIndex = 75
        Me.RB_Insert_2_2.TabStop = True
        Me.RB_Insert_2_2.Text = "Right Insert"
        Me.RB_Insert_2_2.UseVisualStyleBackColor = True
        '
        'Panel_Insert_2_4
        '
        Me.Panel_Insert_2_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_Insert_2_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Insert_2_4.Controls.Add(Me.RB_Insert_2_4)
        Me.Panel_Insert_2_4.Location = New System.Drawing.Point(112, 50)
        Me.Panel_Insert_2_4.Name = "Panel_Insert_2_4"
        Me.Panel_Insert_2_4.Size = New System.Drawing.Size(100, 28)
        Me.Panel_Insert_2_4.TabIndex = 85
        '
        'RB_Insert_2_4
        '
        Me.RB_Insert_2_4.AutoSize = True
        Me.RB_Insert_2_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Insert_2_4.Location = New System.Drawing.Point(3, 3)
        Me.RB_Insert_2_4.Name = "RB_Insert_2_4"
        Me.RB_Insert_2_4.Size = New System.Drawing.Size(82, 20)
        Me.RB_Insert_2_4.TabIndex = 75
        Me.RB_Insert_2_4.Text = "Right/Left"
        Me.RB_Insert_2_4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(844, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Moves"
        '
        'LAB_PartNumber
        '
        Me.LAB_PartNumber.AutoSize = True
        Me.LAB_PartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_PartNumber.Location = New System.Drawing.Point(235, 79)
        Me.LAB_PartNumber.Name = "LAB_PartNumber"
        Me.LAB_PartNumber.Size = New System.Drawing.Size(94, 13)
        Me.LAB_PartNumber.TabIndex = 90
        Me.LAB_PartNumber.Text = "Part#: MANNAME"
        '
        'BUTT_ProgramRun
        '
        Me.BUTT_ProgramRun.Location = New System.Drawing.Point(844, 95)
        Me.BUTT_ProgramRun.Name = "BUTT_ProgramRun"
        Me.BUTT_ProgramRun.Size = New System.Drawing.Size(68, 68)
        Me.BUTT_ProgramRun.TabIndex = 91
        Me.BUTT_ProgramRun.Text = "RUN"
        Me.BUTT_ProgramRun.UseVisualStyleBackColor = True
        '
        'BUTT_ProgramStop
        '
        Me.BUTT_ProgramStop.Location = New System.Drawing.Point(929, 95)
        Me.BUTT_ProgramStop.Name = "BUTT_ProgramStop"
        Me.BUTT_ProgramStop.Size = New System.Drawing.Size(68, 68)
        Me.BUTT_ProgramStop.TabIndex = 92
        Me.BUTT_ProgramStop.Text = "STOP"
        Me.BUTT_ProgramStop.UseVisualStyleBackColor = True
        '
        'BUTT_ProgramPause
        '
        Me.BUTT_ProgramPause.Location = New System.Drawing.Point(1014, 95)
        Me.BUTT_ProgramPause.Name = "BUTT_ProgramPause"
        Me.BUTT_ProgramPause.Size = New System.Drawing.Size(68, 68)
        Me.BUTT_ProgramPause.TabIndex = 93
        Me.BUTT_ProgramPause.Text = "PAUSE"
        Me.BUTT_ProgramPause.UseVisualStyleBackColor = True
        '
        'bgw
        '
        Me.bgw.WorkerReportsProgress = True
        Me.bgw.WorkerSupportsCancellation = True
        '
        'LAB_RunState
        '
        Me.LAB_RunState.BackColor = System.Drawing.Color.Yellow
        Me.LAB_RunState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LAB_RunState.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_RunState.Location = New System.Drawing.Point(238, 373)
        Me.LAB_RunState.Name = "LAB_RunState"
        Me.LAB_RunState.Size = New System.Drawing.Size(600, 75)
        Me.LAB_RunState.TabIndex = 96
        Me.LAB_RunState.Text = "RUNNING"
        Me.LAB_RunState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BUTT_Conn4
        '
        Me.BUTT_Conn4.BackColor = System.Drawing.Color.White
        Me.BUTT_Conn4.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BUTT_Conn4.FlatAppearance.BorderSize = 0
        Me.BUTT_Conn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUTT_Conn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTT_Conn4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BUTT_Conn4.Location = New System.Drawing.Point(109, 109)
        Me.BUTT_Conn4.Name = "BUTT_Conn4"
        Me.BUTT_Conn4.Size = New System.Drawing.Size(100, 100)
        Me.BUTT_Conn4.TabIndex = 3
        Me.BUTT_Conn4.Text = "4"
        Me.BUTT_Conn4.UseVisualStyleBackColor = False
        '
        'BUTT_Conn3
        '
        Me.BUTT_Conn3.BackColor = System.Drawing.Color.White
        Me.BUTT_Conn3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BUTT_Conn3.FlatAppearance.BorderSize = 0
        Me.BUTT_Conn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUTT_Conn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTT_Conn3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BUTT_Conn3.Location = New System.Drawing.Point(3, 109)
        Me.BUTT_Conn3.Name = "BUTT_Conn3"
        Me.BUTT_Conn3.Size = New System.Drawing.Size(100, 100)
        Me.BUTT_Conn3.TabIndex = 2
        Me.BUTT_Conn3.Text = "3"
        Me.BUTT_Conn3.UseVisualStyleBackColor = False
        '
        'BUTT_Conn2
        '
        Me.BUTT_Conn2.BackColor = System.Drawing.Color.White
        Me.BUTT_Conn2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BUTT_Conn2.FlatAppearance.BorderSize = 0
        Me.BUTT_Conn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUTT_Conn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTT_Conn2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BUTT_Conn2.Location = New System.Drawing.Point(109, 3)
        Me.BUTT_Conn2.Name = "BUTT_Conn2"
        Me.BUTT_Conn2.Size = New System.Drawing.Size(100, 100)
        Me.BUTT_Conn2.TabIndex = 1
        Me.BUTT_Conn2.Text = "2"
        Me.BUTT_Conn2.UseVisualStyleBackColor = False
        '
        'BUTT_Conn1
        '
        Me.BUTT_Conn1.BackColor = System.Drawing.Color.White
        Me.BUTT_Conn1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BUTT_Conn1.FlatAppearance.BorderSize = 0
        Me.BUTT_Conn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUTT_Conn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTT_Conn1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BUTT_Conn1.Location = New System.Drawing.Point(3, 3)
        Me.BUTT_Conn1.Name = "BUTT_Conn1"
        Me.BUTT_Conn1.Size = New System.Drawing.Size(100, 100)
        Me.BUTT_Conn1.TabIndex = 0
        Me.BUTT_Conn1.Text = "1"
        Me.BUTT_Conn1.UseVisualStyleBackColor = False
        '
        'TF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 729)
        Me.Controls.Add(Me.LAB_RunState)
        Me.Controls.Add(Me.BUTT_ProgramPause)
        Me.Controls.Add(Me.BUTT_ProgramStop)
        Me.Controls.Add(Me.BUTT_ProgramRun)
        Me.Controls.Add(Me.LAB_PartNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GB_SecondInsert)
        Me.Controls.Add(Me.GB_FirstInsert)
        Me.Controls.Add(Me.BUTT_ClearTray)
        Me.Controls.Add(Me.BUTT_ClearConnector)
        Me.Controls.Add(Me.BUTT_CopyConnector)
        Me.Controls.Add(Me.LAB_Manufacturer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PB_Connector)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_ProgramName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LB_Commands)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TB_Trick)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TF"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C-Davis XY Inserter"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PB_Connector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel_Insert_1_3.ResumeLayout(False)
        Me.Panel_Insert_1_3.PerformLayout()
        Me.Panel_Insert_1_4.ResumeLayout(False)
        Me.Panel_Insert_1_4.PerformLayout()
        Me.Panel_Insert_1_1.ResumeLayout(False)
        Me.Panel_Insert_1_1.PerformLayout()
        Me.Panel_Insert_1_2.ResumeLayout(False)
        Me.Panel_Insert_1_2.PerformLayout()
        Me.GB_FirstInsert.ResumeLayout(False)
        Me.GB_SecondInsert.ResumeLayout(False)
        Me.Panel_2_NONE.ResumeLayout(False)
        Me.Panel_2_NONE.PerformLayout()
        Me.Panel_Insert_2_1.ResumeLayout(False)
        Me.Panel_Insert_2_1.PerformLayout()
        Me.Panel_Insert_2_3.ResumeLayout(False)
        Me.Panel_Insert_2_3.PerformLayout()
        Me.Panel_Insert_2_2.ResumeLayout(False)
        Me.Panel_Insert_2_2.PerformLayout()
        Me.Panel_Insert_2_4.ResumeLayout(False)
        Me.Panel_Insert_2_4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSSL_OnOffline As ToolStripStatusLabel
    Friend WithEvents LB_Commands As ListBox
    Friend WithEvents TB_Trick As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TB_ProgramName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PB_Connector As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LAB_Manufacturer As Label
    Friend WithEvents BUTT_Conn1 As RoundButton
    Friend WithEvents BUTT_Conn4 As RoundButton
    Friend WithEvents BUTT_Conn3 As RoundButton
    Friend WithEvents BUTT_Conn2 As RoundButton
    Friend WithEvents SetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BUTT_CopyConnector As Button
    Friend WithEvents BUTT_ClearConnector As Button
    Friend WithEvents BUTT_ClearTray As Button
    Friend WithEvents Panel_Insert_1_3 As Panel
    Friend WithEvents RB_Insert_1_3 As RadioButton
    Friend WithEvents Panel_Insert_1_4 As Panel
    Friend WithEvents RB_Insert_1_4 As RadioButton
    Friend WithEvents Panel_Insert_1_1 As Panel
    Friend WithEvents RB_Insert_1_1 As RadioButton
    Friend WithEvents Panel_Insert_1_2 As Panel
    Friend WithEvents RB_Insert_1_2 As RadioButton
    Friend WithEvents GB_FirstInsert As GroupBox
    Friend WithEvents GB_SecondInsert As GroupBox
    Friend WithEvents Panel_2_NONE As Panel
    Friend WithEvents RB_Insert_2_NONE As RadioButton
    Friend WithEvents Panel_Insert_2_1 As Panel
    Friend WithEvents RB_Insert_2_1 As RadioButton
    Friend WithEvents Panel_Insert_2_3 As Panel
    Friend WithEvents RB_Insert_2_3 As RadioButton
    Friend WithEvents Panel_Insert_2_2 As Panel
    Friend WithEvents RB_Insert_2_2 As RadioButton
    Friend WithEvents Panel_Insert_2_4 As Panel
    Friend WithEvents RB_Insert_2_4 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents LAB_PartNumber As Label
    Friend WithEvents BUTT_ProgramRun As Button
    Friend WithEvents BUTT_ProgramStop As Button
    Friend WithEvents BUTT_ProgramPause As Button
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents LAB_RunState As Label
    Friend WithEvents DirectControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewConnectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyConnectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyTrayToolStripMenuItem As ToolStripMenuItem
End Class

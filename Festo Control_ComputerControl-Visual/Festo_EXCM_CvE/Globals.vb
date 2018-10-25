Module Globals
    Public DIR_Data As String = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) & "\C-Davis Data"
    Public DIR_Setup As String = DIR_Data & "\Setup Files"
    Public DIR_Connectors As String = DIR_Data & "\Connectors"
    Public DIR_Trays As String = DIR_Data & "\Trays"
    'Public FILE_INI As String = DIR_Data & "\plcip.ini"
    Public FILE_INI As String = DIR_Data & "\cdavis.ini"

    Public Const SoftwareVersion As String = "2.00"
    Public Online As Boolean = False

    Public DisableEvents As Boolean = False

    Public PLC As New classPLC
    Public UserProgram As New objUserProgram
    'Public Connector As New objConnector

    Public NumberOfInserters = 4

    Public ConnTray As New objTray

    Public CurrentConnector As Integer = 0

    'Public Const MAX_UNDO As Integer = 10

    'Public pinbuttlist As New List(Of RoundButton)
    Public pinbuttlist As New List(Of Control_RoundSplitButtonForPictureBox)

    Public UserProgram_Undos As New objUserProgram

    Public SelectedInserter As Integer = 1
    Public SecondInserter As Integer = 0

    Public InserterDescription As String() = {"PLACEHOLDER", "Inserter 1", "Inserter 2", "Inserter 3", "Inserter 4"}
    Public InserterColors As Color() = {Color.Black, Color.Tomato, Color.Gray, Color.LightGreen, Color.PaleTurquoise}
    Public InserterX As Decimal() = {0, 60, 40, 60, 40}
    Public InserterY As Decimal() = {0, 50, 50, 65, 65}

    Public GantrySpeed As Decimal = 200

    Public bgw_command As String = ""

    'Public XY_System As New objXY_System

End Module

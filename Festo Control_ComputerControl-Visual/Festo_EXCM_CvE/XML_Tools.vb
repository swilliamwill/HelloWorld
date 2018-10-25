Imports System.Xml

Module XML_Tools
    Const CTab As Char = ControlChars.Tab
    Const CQte As Char = ControlChars.Quote

    Friend Function XML_CreateNewFile(filename As String) As XmlWriter
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True

        ' Create XmlWriter.
        Dim xWrite As XmlWriter = XmlWriter.Create(filename, settings)
        xWrite.WriteStartDocument()

        Return xWrite
    End Function

    Friend Sub XML_Close(ByRef xWrite As XmlWriter)
        xWrite.WriteEndElement()
        xWrite.WriteEndDocument()
        xWrite.Close()
    End Sub

    Friend Sub XML_TrayProgramHeader(ByRef xWrite As XmlWriter, ByVal tray As objTray)
        xWrite.WriteComment("C-Davis Plug Inserter")

        xWrite.WriteStartElement("trayprogramfile") ' Root.
        xWrite.WriteAttributeString("softwareversion", SoftwareVersion)

        xWrite.WriteElementString("creation_date", DateTime.Now)
        xWrite.WriteElementString("programname", tray.TrayProgramName)
    End Sub

    Friend Sub XML_ConnectorHeader(ByRef xWrite As XmlWriter)
        xWrite.WriteComment("C-Davis Plug Inserter")

        xWrite.WriteStartElement("connectorprogramfile") ' Root.
        xWrite.WriteAttributeString("softwareversion", SoftwareVersion)

        xWrite.WriteElementString("creation_date", DateTime.Now)
    End Sub

#Region "Connector File"

    Public Sub XML_Connector_GetData(Conn As objConnector, m_node As XmlNode)
        For Each cn As XmlNode In m_node.ChildNodes
            Select Case cn.Name
                Case "manufacturer"
                    Conn.Manufacturer = cn.InnerText

                Case "partnumber"
                    Conn.PartNumber = cn.InnerText

                Case "name"
                    Conn.Name = cn.InnerText
            End Select
        Next
    End Sub

    Private Sub XML_WriteOutline(ByRef xWrite As XmlWriter, ByVal outline As objOutline)
        With outline
            xWrite.WriteStartElement("outline")
            xWrite.WriteElementString("shape", .Shape)
            xWrite.WriteElementString("p1", .point1.X & "," & .point1.Y)

            Select Case .Shape.ToLower
                Case "circle"
                    xWrite.WriteElementString("diameter", .Diameter)
                Case "rectangle"
                    xWrite.WriteElementString("p2", .point2.X & "," & .point2.Y)
            End Select

            xWrite.WriteElementString("linethickness", .LineThickness)
            xWrite.WriteEndElement()
        End With
    End Sub

    Function XML_Connector_GetOutline(m_node As XmlNode) As objOutline
        Dim NewOutline As New objOutline

        For Each cn As XmlNode In m_node.ChildNodes
            Select Case cn.Name
                Case "shape"
                    NewOutline.Shape = cn.InnerText

                Case "p1"
                    NewOutline.point1.X = cn.InnerText.Split(",")(0)
                    NewOutline.point1.Y = cn.InnerText.Split(",")(1)

                Case "p2"
                    NewOutline.point2.X = cn.InnerText.Split(",")(0)
                    NewOutline.point2.Y = cn.InnerText.Split(",")(1)

                Case "diameter"
                    NewOutline.Diameter = cn.InnerText

                Case "linethickness"
                    NewOutline.LineThickness = cn.InnerText
            End Select
        Next

        Return NewOutline
    End Function

    Public Sub XML_Connector_GetDrawingInfo(Conn As objConnector, m_node As XmlNode)
        For Each cn As XmlNode In m_node.ChildNodes
            Select Case cn.Name
                Case "units"
                    Conn.Units = cn.InnerText

                Case "facing"
                    Conn.BackFacing = (cn.InnerText.ToLower = "back")

                Case "size"
                    For Each cn2 As XmlNode In cn.ChildNodes
                        Select Case cn2.Name
                            Case "x"
                                Conn.SizeX = cn2.InnerText
                            Case "y"
                                Conn.SizeY = cn2.InnerText
                            Case Else
                        End Select
                    Next

                Case "pinrefzero"
                    For Each cn2 As XmlNode In cn.ChildNodes
                        Select Case cn2.Name
                            Case "x"
                                Conn.PinRefZeroX = cn2.InnerText
                            Case "y"
                                Conn.PinRefZeroY = cn2.InnerText
                            Case Else
                        End Select
                    Next

                Case "outlines"
                    For Each cn2 As XmlNode In cn.ChildNodes
                        Conn.OutlineShapes.Add(XML_Connector_GetOutline(cn2))
                    Next
            End Select
        Next
    End Sub

    Private Sub XML_WritePin(ByRef xWrite As XmlWriter, ByVal pin As objConnector_Pin)
        xWrite.WriteStartElement("pin")
        xWrite.WriteElementString("name", pin.Name)
        xWrite.WriteElementString("x", pin.X)
        xWrite.WriteElementString("y", pin.Y)
        xWrite.WriteElementString("diam", pin.Diameter)

        If pin.InsertOrder <> "" Then xWrite.WriteElementString("insertorder", pin.InsertOrder)

        xWrite.WriteEndElement()
    End Sub

    Public Function XML_Connector_GetPin(m_node As XmlNode) As objConnector_Pin
        Dim pin As New objConnector_Pin

        For Each cn As XmlNode In m_node.ChildNodes
            Select Case cn.Name
                Case "name"
                    pin.Name = cn.InnerText

                Case "x"
                    pin.X = cn.InnerText

                Case "y"
                    pin.Y = cn.InnerText

                Case "diam"
                    pin.Diameter = cn.InnerText

                Case "insertorder"
                    pin.InsertOrder = cn.InnerText
            End Select
        Next

        Return pin
    End Function

    Public Sub Write_XML_Connector(ByRef xWrite As XmlWriter, ByVal conn As objConnector)
        'Write a connector into an open XML file

        xWrite.WriteStartElement("connector")

        If conn.TrayIndex > 0 Then xWrite.WriteElementString("trayindex", conn.TrayIndex)

        xWrite.WriteStartElement("data")
        xWrite.WriteElementString("name", conn.Name)
        xWrite.WriteElementString("manufacturer", conn.Manufacturer)
        xWrite.WriteElementString("partnumber", conn.PartNumber)
        xWrite.WriteEndElement()

        xWrite.WriteStartElement("drawing")
        xWrite.WriteElementString("units", conn.Units)

        If conn.BackFacing Then
            xWrite.WriteElementString("facing", "back")
        Else
            xWrite.WriteElementString("facing", "front")
        End If

        xWrite.WriteStartElement("size")
        xWrite.WriteElementString("x", conn.SizeX)
        xWrite.WriteElementString("y", conn.SizeY)
        xWrite.WriteEndElement()

        xWrite.WriteStartElement("pinrefzero")
        xWrite.WriteElementString("x", conn.PinRefZeroX)
        xWrite.WriteElementString("y", conn.PinRefZeroX)
        xWrite.WriteEndElement()

        xWrite.WriteStartElement("outlines")

        For Each o As objOutline In conn.OutlineShapes
            XML_WriteOutline(xWrite, o)
        Next

        xWrite.WriteEndElement()
        xWrite.WriteEndElement()

        'For Each cmd As Object In UserProgram.CommandList
        '   
        xWrite.WriteStartElement("pins")
        For Each pin As objConnector_Pin In conn.Pins
            XML_WritePin(xWrite, pin)
        Next
        xWrite.WriteEndElement()

        '    XML_WriteCommand(xWrite, cmd)
        'Next
        xWrite.WriteEndElement()
    End Sub

    Public Function XML_GetConnector(m_node As XmlNode, Optional ConvertForOperation As Boolean = True) As objConnector
        Dim NewConn As New objConnector

        For Each cn As XmlNode In m_node.ChildNodes
            Select Case cn.Name
                Case "trayindex"
                    NewConn.TrayIndex = cn.InnerText

                Case "data"
                    XML_Connector_GetData(NewConn, cn)

                Case "drawing"
                    XML_Connector_GetDrawingInfo(NewConn, cn)

                Case "pins"
                    For Each cn2 As XmlNode In cn
                        NewConn.Pins.Add(XML_Connector_GetPin(cn2))
                    Next
            End Select
        Next

        If Not ConvertForOperation Then Return NewConn 'We're done, return the connector

        'Now that the connector has been loaded we need to put it in the correct form for our use (metric/look at back)
        If Not NewConn.BackFacing Then
            NewConn.BackFacing = True
            For Each pin As objConnector_Pin In NewConn.Pins
                pin.X = -pin.X
            Next

            For Each outline As objOutline In NewConn.OutlineShapes
                outline.point1.X = -outline.point1.X
                outline.point2.X = -outline.point2.X
            Next
        End If

        If NewConn.Units = "inch" Then 'Convert to metric for gantry
            NewConn.Units = "mm"
            NewConn.SizeX *= 25.4
            NewConn.SizeY *= 25.4

            NewConn.TrayPositionX *= 25.4
            NewConn.TrayPositionY *= 25.4

            NewConn.PinRefZeroX *= 25.4
            NewConn.PinRefZeroY *= 25.4

            For Each pin As objConnector_Pin In NewConn.Pins
                pin.X *= 25.4
                pin.Y *= 25.4
                pin.Diameter *= 25.4
            Next

            For Each outline As objOutline In NewConn.OutlineShapes
                outline.point1 *= 25.4
                outline.point2 *= 25.4
                outline.Diameter *= 25.4
            Next
        End If

        Return NewConn
    End Function

    Public Sub LOAD_XML_ConnectorFile(filename As String, ByRef NewConn As objConnector, EraseAll As Boolean)
        If (filename = "") OrElse (Not My.Computer.FileSystem.FileExists(filename)) Then
            MessageBox.Show("Empty file or file does not exist")
            Exit Sub
        End If

        Dim SoftwareVersion As String

        If System.IO.File.Exists(filename) Then
            Dim m_xmld As XmlDocument
            Dim m_node As XmlNode

            If EraseAll Then NewConn = New objConnector

            m_xmld = New XmlDocument() 'Create the XML Document for reading
            m_xmld.Load(filename)  'Load the Xml file

            'Get the setup file version (if needed)
            m_node = m_xmld.SelectSingleNode("connectorprogramfile")
            SoftwareVersion = m_node.Attributes(0).InnerText

            'Get connectors
            NewConn = XML_GetConnector(m_xmld.SelectSingleNode("connectorprogramfile/connector"))
        End If
    End Sub
#End Region

#Region "User Program"

    Public Sub SAVE_XML_TrayProgram(filename As String, ByVal tray As objTray)
        Dim xWrite As XmlWriter = XML_CreateNewFile(filename)

        XML_TrayProgramHeader(xWrite, tray)

        xWrite.WriteStartElement("connectors")
        For Each conn As objConnector In tray.Connectors
            Write_XML_Connector(xWrite, conn)
        Next
        xWrite.WriteEndElement()

        XML_Close(xWrite)
    End Sub

    Public Sub SAVE_XML_Connector(filename As String, ByVal conn As objConnector)
        Dim xWrite As XmlWriter = XML_CreateNewFile(filename)

        XML_ConnectorHeader(xWrite)
        Write_XML_Connector(xWrite, conn)
        XML_Close(xWrite)
    End Sub

    Public Sub LOAD_XML_TrayProgram(filename As String, TrayProgram As objTray)
        If (filename = "") OrElse (Not My.Computer.FileSystem.FileExists(filename)) Then
            MessageBox.Show("Empty file or file does not exist")
            Exit Sub
        End If

        Dim SoftwareVersion As String

        If System.IO.File.Exists(filename) Then
            Dim m_xmld As XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode

            m_xmld = New XmlDocument() 'Create the XML Document for reading
            m_xmld.Load(filename)  'Load the Xml file

            TrayProgram.ClearAllData() 'Clear the tray

            'Get the setup file version (if needed)
            m_node = m_xmld.SelectSingleNode("trayprogramfile")
            SoftwareVersion = m_node.Attributes(0).InnerText

            m_node = m_xmld.SelectSingleNode("/trayprogramfile/programname")
            TrayProgram.TrayProgramName = m_node.InnerText

            'Get connectors
            m_nodelist = m_xmld.SelectNodes("/trayprogramfile/connectors/connector")
            For Each m_node In m_nodelist
                TrayProgram.Connectors.Add(XML_GetConnector(m_node))
            Next
        End If
    End Sub

    Public Function XML_Tray_GetConnector(m_node As XmlNode) As objConnector
        Dim Conn As New objConnector

        For cn As Integer = 0 To m_node.ChildNodes.Count - 1

            Dim tempvar As String = m_node.ChildNodes.Item(cn).Name

            Select Case m_node.ChildNodes.Item(cn).Name
                Case "data"
                    'For Each cn2 In m_node.ChildNodes.Item(cn)
                    XML_Connector_GetData(Conn, m_node)
                   ' Next

                Case "x"
                 '   pin.X = m_node.ChildNodes.Item(cn).InnerText

                Case "y"
                   ' pin.Y = m_node.ChildNodes.Item(cn).InnerText

                Case "diam"
                  '  pin.Diameter = m_node.ChildNodes.Item(cn).InnerText

                Case "insertorder"
                    '  pin.InsertOrder = m_node.ChildNodes.Item(cn).InnerText

            End Select
        Next

        'm_nodelist = m_xmld.SelectNodes("/connector/")
        ' XML_GetConnector(NewConn, m_node)

        'Get Basic Data
        'm_nodelist = m_xmld.SelectNodes("/connector/data")
        'For Each m_node In m_nodelist

        'Next

        ''Get Drawing Units/Refernce Zero etc
        'm_nodelist = m_xmld.SelectNodes("/connector/drawing")
        'For Each m_node In m_nodelist
        '    XML_Connector_GetDrawingInfo(NewConn, m_node)
        'Next

        ''Get the pins
        'm_nodelist = m_xmld.SelectNodes("/connector/pins/pin")
        'For Each m_node In m_nodelist
        '    NewConn.Pins.Add(XML_Connector_GetPin(m_node))
        'Next

        Return Conn
    End Function
#End Region
End Module

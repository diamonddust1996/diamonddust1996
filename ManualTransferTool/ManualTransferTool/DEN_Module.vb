Imports Microsoft.Office.Interop

Module DEN_Module
    Public Sub Den_Trans(ByVal strFile As String, ByVal sTypeData As String, ByVal sData As String, ByVal sTrans As String)
        Dim ExlApp As Excel.Application
        Dim ExlBook As Excel.Workbook
        Dim ExlSheet As Excel.Worksheet
        'Dim ExlSheetMP_Roll As Excel.Worksheet
        Dim i As Integer
        'Dim j As Integer
        Dim y As Integer
        Dim z As Integer
        Dim sType As String
        Dim sLot As String
        Dim sRoll As String
        Dim sSlit As String
        Dim sSet As String
        Dim sY_Flg As String
        Dim sYK_Flg As String
        Dim sOpeName As String
        Dim sDay As String
        Dim sTime As String
        Dim sRetryFlg As String
        Dim sRefFlg As String
        Dim sChkFlg As String
        Dim sTester As String
        Dim sAMP_U As String
        Dim sAMP_L As String
        Dim sAMP As String
        Dim sSNRsk_L As String
        Dim sSNRsk As String
        Dim sBBSNR_L As String
        Dim sBBSNR As String
        Dim sOW_U As String
        Dim sOW As String
        Dim sRes_U As String
        Dim sRes_L As String
        Dim sRes As String
        Dim sORC_U As String
        Dim sORC_L As String
        Dim sORC As String
        Dim sOpeFLG As String
        Dim sDEN_Create As String
        Dim sDEN_UPDATE As String
        'Dim iPrnFileCnt As Integer
        Dim iCnt As Integer
        Dim sSet_Name As String
        Dim bExcelOpenFlg As Boolean
        Dim sSelectionFlg As String
        'Dim sTrans As String   '引数へ変更

        iCnt = 1


        bExcelOpenFlg = True
        'Excelﾌｧｲﾙを開く
        ExlApp = CreateObject("Excel.Application")
        ExlBook = ExlApp.Workbooks.Open(strFile)
        ExlSheet = ExlBook.Worksheets("電特結果入力")
        'ExlSheetDen = ExlBook.Worksheets("電特一覧表")

        'Open sSvData & "DUMMY.prn" For Output As #1
        'Close #1

        'If InStr(sTypeData, "V") > 0 Then
        '    sTrans = "\\192.168.203.7\QA04\QA04\LTO\RECV\DEN\"
        '    'sTrans = "\\CFS-01\HOME1\11304431\Desktop\soft\手動転送ツール gennshi\WindowsApp1\TEST\"
        'ElseIf InStr(sTypeData, "C") > 0 Then
        '    sTrans = "\\192.168.203.7\QA04\QA04\CHOU\RECV\DEN\"
        '    'sTrans = "\\CFS-01\HOME1\11304431\Desktop\soft\手動転送ツール gennshi\WindowsApp1\TEST\"
        'End If

        Dim DummyFile As New System.IO.StreamWriter(sTrans & "DUMMY.prn")
        '閉じる
        DummyFile.Close()


        i = 12
        z = 6
        Do While i < 64

            If ExlSheet.Range("B" & i).Value <> "" Then
                '品種
                sType = Split(ExlSheet.Range("B" & i).Value, "_")(0)
                If Left(Split(ExlSheet.Range("B" & i).Value, "_")(1), 1) = "R" Or Left(Split(ExlSheet.Range("B" & i).Value, "_")(1), 1) = "T" Or Left(Left(Split(ExlSheet.Range("B" & i).Value, "_")(1), 1), 1) = "W" Or Left(Left(Split(ExlSheet.Range("B" & i).Value, "_")(1), 1), 1) = "9" Then
                    'Lot
                    sLot = Left(Split(ExlSheet.Range("B" & i).Value, "_")(1), 4)
                    'ROLL
                    sRoll = Mid(Split(ExlSheet.Range("B" & i).Value, "_")(1), 5, Len(Split(ExlSheet.Range("B" & i).Value, "_")(1)) - Len(sLot))

                Else
                    'Lot
                    sLot = Left(Split(ExlSheet.Range("B" & i).Value, "_")(1), 3)
                    'ROLL
                    sRoll = Mid(Split(ExlSheet.Range("B" & i).Value, "_")(1), 4, Len(Split(ExlSheet.Range("B" & i).Value, "_")(1)) - Len(sLot))
                End If
                'SLIT
                sSlit = Left(Split(ExlSheet.Range("B" & i).Value, "_")(2), 2)
                'SET
                If InStr(Right(ExlSheet.Range("B" & i).Value, 2), "-") > 0 Then

                    sSet = Left(Right(ExlSheet.Range("B" & i).Value, 4), 2)
                    sSet_Name = Right(ExlSheet.Range("B" & i).Value, 2)

                Else

                    sSet = Right(ExlSheet.Range("B" & i).Value, 2)
                    sSet_Name = ""
                End If

                If InStr(ExlSheet.Range("B" & i).Value, "REF") >= 1 Then
                    sSet_Name = Mid(Split(ExlSheet.Range("B" & i).Value, "_")(2), 4)
                    sSet = Left(Mid(Split(ExlSheet.Range("B" & i).Value, "_")(2), 4), 2)
                End If
                '要変フラグ
                sY_Flg = "F"
                '要変工程フラグ
                sYK_Flg = "F"
                '測定者
                sOpeName = ExlSheet.Range("B3").Value
                '転送日
                sDay = Split(Left(Today, 10), "/")(0) & Split(Left(Today, 10), "/")(1) & Split(Left(Today, 10), "/")(2)
                '転送時間
                sTime = Split(Mid(Now, 12, 20), ":")(0) & Split(Mid(Now, 12, 20), ":")(1) & Split(Mid(Now, 12, 20), ":")(2)
                '再測フラグ
                If sSet_Name <> "" And InStr(sSet_Name, "REF") = 0 Then
                    y = y + 1
                    If InStr(ExlSheet.Range("B" & i + 1).Value, sLot & sRoll & "_" & sSlit & " " & sSet) = 0 And InStr(ExlSheet.Range("B" & i - 1).Value, sLot & sRoll & "_" & sSlit & " " & sSet) = 0 Then
                        y = 0
                    End If

                    sRetryFlg = y

                Else
                    sRetryFlg = "0"
                End If
                'REFフラグ
                If InStr(ExlSheet.Range("B" & i).Value, "REF") >= 1 Then
                    If i = 12 Then
                        sRefFlg = "1"
                    Else
                        sRefFlg = "2"
                    End If
                Else
                    sRefFlg = "0"
                End If
                'チェックフラグ
                sChkFlg = "0"

                '測定機
                sTester = Left(ExlSheet.Range("B5").Value, 12)

                sAMP_U = Split(Split(sData, ",")(0), "～")(1)

                sAMP_L = Split(Split(sData, ",")(0), "～")(0)

                sAMP = ExlSheet.Range("D" & i).Value

                sSNRsk_L = Split(sData, ",")(1)

                sSNRsk = ExlSheet.Range("F" & i).Value

                sBBSNR_L = Split(sData, ",")(2)

                sBBSNR = ExlSheet.Range("H" & i).Value

                sOW_U = Split(sData, ",")(3)

                sOW = ExlSheet.Range("J" & i).Value

                sRes_U = Split(Split(sData, ",")(4), "～")(1)

                sRes_L = Split(Split(sData, ",")(4), "～")(0)

                sRes = ExlSheet.Range("L" & i).Value

                sORC_U = Split(Split(sData, ",")(5), "～")(1)

                sORC_L = Split(Split(sData, ",")(5), "～")(0)

                sORC = ExlSheet.Range("N" & i).Value

                sOpeFLG = ""

                sSelectionFlg = ""

                sDEN_Create = ""

                sDEN_UPDATE = ""


                Dim sw As Object


                If sRefFlg >= 1 Then
                    sw = New System.IO.StreamWriter(sTrans & sDay & sTime & "_" & sType & "_" & sLot & sRoll & "_" & sSlit & " " & sSet & " REF_DEN.prn") '', False, System.Text.Encoding.GetEncoding("shift_jis")) 'Shift JISで書き込む
                    '書き込むファイルが既に存在している場合は、上書きする
                Else
                    sw = New System.IO.StreamWriter(sTrans & sDay & sTime & "_" & sType & "_" & sLot & sRoll & "_" & sSlit & " " & sSet & "_DEN.prn")
                End If


                'TextBox1.Textの内容を書き込む
                sw.Write(sType & "," & sLot & "," & sRoll & "," & sSlit & "," & sSet & "," & sY_Flg & "," &
                sYK_Flg & "," & sOpeName & "," & sDay & "," & sTime & "," & sRetryFlg & "," & sRefFlg & "," &
                sChkFlg & "," & sTester & "," & sTester & "," & sAMP_U & "," & sAMP_L & "," & sAMP & "," &
                sSNRsk_L & "," & sSNRsk & "," & sBBSNR_L & "," & sBBSNR & "," & sOW_U & "," &
                sOW & "," & sRes_U & "," & sRes_L & "," & sRes & "," & sORC_U & "," &
                sORC_L & "," & sORC & "," & sOpeFLG & "," & sSelectionFlg & "," & sDEN_Create & "," & sDEN_UPDATE)

                System.Threading.Thread.Sleep(1000)

                '閉じる
                sw.Close()
                '    Open sSvData & sDay & sTime & "_" & sType & "_" & sLot & sRoll & "_" & sSlit & " " & sSet_Name & "_DEN.prn" For Output As #1

                '    Print #1, sType & "," & sLot & "," & sRoll & "," & sSlit & "," & sSet & "," & sY_Flg & "," &
                '              sYK_Flg & "," & sOpeName & "," & sDay & "," & sTime & "," & sRetryFlg & "," & sRefFlg & "," &
                '              sChkFlg & "," & sTester & "," & sTester & "," & sAMP_U & "," & sAMP_L & "," & sAMP & "," &
                '              sSNRsk_L & "," & sSNRsk & "," & sBBSNR_L & "," & sBBSNR & "," & sOW_U & "," &
                '              sOW & "," & sRes_U & "," & sRes_L & "," & sRes & "," & sORC_U & "," &
                '              sORC_L & "," & sORC & "," & sOpeFLG & "," & sSelectionFlg & "," & sDEN_Create & "," & sDEN_UPDATE

                'Close

            End If

            i = i + 1

        Loop

        '変更の保存
        ExlBook.Close()
        ExlApp.Quit()

        ExlSheet = Nothing
        ExlBook = Nothing
        ExlApp = Nothing

        Dim ps As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcessesByName("Excel.Application")
        For Each p As System.Diagnostics.Process In ps
            'プロセスを強制的に終了させる
            p.Kill()
        Next


        'ﾀﾞﾐｰﾌｧｲﾙの削除

        System.IO.File.Delete(sTrans & "DUMMY.prn")

        'prnﾌｧｲﾙの確認
        'strFile = Dir$(sSvData & "DUMMY.prn")
        'iPrnFileCnt = 0
        'prnﾌｧｲﾙのﾌｧｲﾙ数の確認
        'Do Until strFile = ""
        '    iPrnFileCnt = iPrnFileCnt + 1
        '    strFile = Dir$()
        'Loop
        'If iPrnFileCnt <> 0 Then
        '    Kill sSvData & "DUMMY.prn"
        'End If

    End Sub

End Module

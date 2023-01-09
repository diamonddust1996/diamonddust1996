Imports Microsoft.Office.Interop

Module MP_Module

    Public Sub LTO_MP_Trans(ByVal strFile As String, ByVal sTypeData As String, ByVal sData As String, ByVal sTrans As String)
        Dim ExlApp As Excel.Application
        Dim ExlBook As Excel.Workbook
        Dim ExlSheet As Excel.Worksheet
        'Dim ExlSheetMP_Roll As Excel.Worksheet
        Dim i As Integer
        Dim y As Integer
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
        Dim sTapeLen As String
        Dim sMp_U As String
        Dim sMP As String
        Dim sBlockData(0 To 14) As String
        Dim sBMP_U As String
        Dim sBMP As String
        Dim s90Block_U As String
        Dim s90Block As String
        Dim sShortD_U As String
        Dim sShortD As String
        Dim sLongD_U As String
        Dim sLongD As String
        Dim sAve_LD_U As String
        Dim sAVE_LD As String
        Dim sCQBlock(0 To 15) As String
        Dim sOpeFLG As String
        Dim sSelectFlg As String
        Dim sMp_Create_Date As String
        Dim sMp_UPdate_Date As String
        'Dim iPrnFileCnt As Integer
        'Dim iCnt As Integer
        'Dim bExcelOpenFlg As Boolean
        'Dim sTrans As String

        ExlApp = CreateObject("Excel.Application")
        ExlBook = ExlApp.Workbooks.Open(strFile)

        'If InStr(sTypeData, "VY") = 0 And InStr(sTypeData, "VZ") = 0 Then
        ExlSheet = ExlBook.Worksheets("MPロール結果")
        'ExlSheetMP_Roll = ExlBook.Worksheets("MPロール結果まとめ")
        'Else
        '    ExlSheet = ExlBook.Worksheets("MPロール結果")
        '    ''ExlSheetMP_Roll = ExlBook.Worksheets("結果")
        'End If

        'Open sSaveData & "DUMMY.prn" For Output As #1
        'Close #1
        'sTrans = "\\192.168.203.7\QA04\QA04\LTO\RECV\MP\"

        'sTrans = "\\CFS-01\HOME1\11304431\Desktop\soft\手動転送ツール gennshi\WindowsApp1\TEST\"

        Dim DummyFile As New System.IO.StreamWriter(sTrans & "DUMMY.prn")
        '閉じる
        DummyFile.Close()


        i = 6

        While ExlSheet.Range("B" & i).Value <> ""
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
            sSet = Right(ExlSheet.Range("B" & i).Value, 2)
            '要変フラグ
            sY_Flg = "F"
            '要変工程フラグ
            sYK_Flg = "F"
            '測定者
            sOpeName = ExlSheet.Range("G" & i).Value

            '転送日
            sDay = Split(Left(Today, 10), "/")(0) & Split(Left(Today, 10), "/")(1) & Split(Left(Today, 10), "/")(2)
            '転送時間
            sTime = Split(Mid(Now, 12, 20), ":")(0) & Split(Mid(Now, 12, 20), ":")(1) & Split(Mid(Now, 12, 20), ":")(2)

            If Len(sTime) = 5 Then

                sTime = "0" & sTime

            End If

            '再測フラグ
            If ExlSheet.Range("B" & i).Value = ExlSheet.Range("B" & i + 1).Value Or y <> 0 Then
                sRetryFlg = y
                y = y + 1
                If ExlSheet.Range("B" & i).Value <> ExlSheet.Range("B" & i + 1).Value Then
                    y = 0
                End If
            Else
                sRetryFlg = "0"
            End If
            'REFフラグ
            If InStr(ExlSheet.Range("B" & i).Value, "REF") >= 1 Then
                sRefFlg = "1"
            Else
                sRefFlg = "0"
            End If
            'チェックフラグ
            sChkFlg = "0"

            '測定機
            sTester = Left(ExlSheet.Range("K" & i).Value, 12)

            '測定長
            sTapeLen = ExlSheet.Range("J" & i).Value

            'ブロックデータ
            For j = 0 To 14
                sBlockData(j) = ""
            Next j
            'B-MP上限
            sBMP_U = "0"

            'B-MP
            sBMP = ExlSheet.Range("P" & i).Value

            If Left(sTypeData, 2) = "VT" Or Left(sTypeData, 2) = "VX" Then

                'MP上限
                sMp_U = Split(sData, ",")(0)

                'MP
                sMP = ExlSheet.Range("O" & i).Value

                '90mブロック上限　※取得出来ない為、空白
                s90Block_U = Split(sData, ",")(1)

                '90mブロック　※取得出来ない為、空白
                s90Block = ExlSheet.Range("X" & i).Value

                'Short上限
                sShortD_U = ""

                'Short
                sShortD = ExlSheet.Range("U" & i).Value

                'Long上限
                sLongD_U = ""
                'Long
                sLongD = ExlSheet.Range("V" & i).Value

                'Ave_Long上限
                sAve_LD_U = ""
                'Ave_Long
                sAVE_LD = ExlSheet.Range("W" & i).Value

                'CQブロック
                For j = 0 To 15
                    sCQBlock(j) = ""
                Next j

            Else

                'MP上限
                sMp_U = "5.5"

                'MP
                sMP = ExlSheet.Range("O" & i).Value

                '90mブロック上限　※取得出来ない為、空白
                s90Block_U = ""

                '90mブロック　※取得出来ない為、空白
                s90Block = ""

                sShortD_U = Split(sData, ",")(0)
                sShortD = ExlSheet.Range("U" & i).Value
                sLongD_U = Split(sData, ",")(1)
                sLongD = ExlSheet.Range("V" & i).Value
                sAve_LD_U = ""
                sAVE_LD = ExlSheet.Range("W" & i).Value

            End If

            sOpeFLG = ""
            sSelectFlg = ""
            sMp_Create_Date = ""
            sMp_UPdate_Date = ""


            'Shift JISで書き込む
            '書き込むファイルが既に存在している場合は、上書きする

            Dim sw As New System.IO.StreamWriter(sTrans & sDay & sTime & "_" & sType & "_" & sLot & sRoll & "_" & sSlit & " " & sSet & ".prn") '', False, System.Text.Encoding.GetEncoding("shift_jis"))

            'If Left(sTypeData, 2) <> "VT" Or Left(sTypeData, 2) <> "VX" Then
            'TextBox1.Textの内容を書き込む
            sw.Write(sType & "," & sLot & "," & sRoll & "," & sSlit & "," & sY_Flg & "," &
            sYK_Flg & "," & sOpeName & "," & sDay & "," & sTime & "," & sRetryFlg & "," & sRefFlg & "," &
            sChkFlg & "," & sTester & "," & sTapeLen & "," & sTester & "," & sSet & "," &
            sMp_U & "," & sMP & "," & sBlockData(0) & "," & sBlockData(1) & "," & sBlockData(2) _
            & "," & sBlockData(3) & "," & sBlockData(4) & "," & sBlockData(5) & "," & sBlockData(6) _
            & "," & sBlockData(7) & "," & sBlockData(8) & "," & sBlockData(9) & "," & sBlockData(10) _
            & "," & sBlockData(11) & "," & sBlockData(12) & "," & sBlockData(13) & "," & sBlockData(14) _
            & "," & sBMP_U & "," & sBMP & "," & s90Block_U & "," & s90Block & "," & sShortD_U & "," & sShortD _
            & "," & sLongD_U & "," & sLongD & "," & sAve_LD_U & "," & sAVE_LD & "," & sCQBlock(0) _
            & "," & sCQBlock(1) & "," & sCQBlock(2) & "," & sCQBlock(3) & "," & sCQBlock(4) & "," & sCQBlock(5) _
            & "," & sCQBlock(6) & "," & sCQBlock(7) & "," & sCQBlock(8) & "," & sCQBlock(9) & "," & sCQBlock(10) _
            & "," & sCQBlock(11) & "," & sCQBlock(12) & "," & sCQBlock(13) & "," & sCQBlock(14) & "," & sCQBlock(15) _
            & "," & sOpeFLG & "," & sSelectFlg & "," & sMp_Create_Date & "," & sMp_UPdate_Date)
            'Else
            '    sw.Write(sType & "," & sLot & "," & sRoll & "," & sSlit & "," & sY_Flg & "," &
            '                  sYK_Flg & "," & sOpeName & "," & sDay & "," & sTime & "," & sRetryFlg & "," & sRefFlg & "," &
            '                      sChkFlg & "," & sTester & "," & sTapeLen & "," & sTester & "," & sSet & "," &
            '                      sMp_U & "," & sMP & "," & sBlockData(0) & "," & sBlockData(1) & "," & sBlockData(2) _
            '                      & "," & sBlockData(3) & "," & sBlockData(4) & "," & sBlockData(5) & "," & sBlockData(6) _
            '                      & "," & sBlockData(7) & "," & sBlockData(8) & "," & sBlockData(9) & "," & sBlockData(10) _
            '                      & "," & sBMP_U & "," & sBMP _
            '                      & "," & sOpeFLG & "," & sSelectFlg & "," & sMp_Create_Date & "," & sMp_UPdate_Date)
            'End If

            System.Threading.Thread.Sleep(1000)

            '閉じる
            sw.Close()

            i = i + 1


        End While

        '変更の保存
        ExlBook.Close()
        ExlApp.Quit()

        'ExlSheetMP_Roll = Nothing
        ExlSheet = Nothing
        ExlBook = Nothing
        ExlApp = Nothing

        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlSheetMP_Roll)
        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlSheet)
        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlBook)
        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlApp)



        'ﾀﾞﾐｰﾌｧｲﾙの削除

        System.IO.File.Delete(sTrans & "DUMMY.prn")

        'prnﾌｧｲﾙの確認
        'strFile = Dir$(sSaveData & "DUMMY.prn")
        'iPrnFileCnt = 0
        '''prnﾌｧｲﾙのﾌｧｲﾙ数の確認
        'Do Until strFile = ""
        '    iPrnFileCnt = iPrnFileCnt + 1
        '    strFile = Dir$()
        'Loop
        'If iPrnFileCnt <> 0 Then
        '    Kill sSaveData & "DUMMY.prn"
        'End If



    End Sub
    Public Sub CHOU_MP_Trans(ByVal strFile As String, ByVal sTypeData As String, ByVal sData As String)
        'CHOU G3,G4
        Dim ExlApp As Excel.Application
        Dim ExlBook As Excel.Workbook
        Dim ExlSheet As Excel.Worksheet
        'Dim ExlSheetMP_Roll As Excel.Worksheet
        Dim i As Integer
        Dim j As Integer
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
        Dim sTapeLen As String
        Dim sMp_U As String
        Dim sMP As String
        Dim sBlockData(0 To 14) As String
        Dim sBMP_U As String
        Dim sBMP As String
        Dim s90Block_U As String
        Dim s90Block As String
        'Dim sShortD_U As String
        'Dim sShortD As String
        'Dim sLongD_U As String
        'Dim sLongD As String
        'Dim sAve_LD_U As String
        'Dim sAVE_LD As String
        Dim sCQBlock(0 To 15) As String
        Dim sOpeFLG As String
        Dim sSelectFlg As String
        Dim sMp_Create_Date As String
        Dim sMp_UPdate_Date As String
        'Dim iPrnFileCnt As Integer
        Dim iCnt As Integer
        Dim bExcelOpenFlg As Boolean
        Dim sTrans As String



        'Open sSaveData & "DUMMY.prn" For Output As #1
        'Close #1

        sTrans = "\\192.168.203.7\QA04\QA04\CHOU\RECV\MP\"

        'sTrans = "\\CFS-01\HOME1\11304431\Desktop\soft\手動転送ツール gennshi\WindowsApp1\TEST\"

        Dim DummyFile As New System.IO.StreamWriter(sTrans & "DUMMY.prn")
        '閉じる
        DummyFile.Close()

        iCnt = 1

        bExcelOpenFlg = True
        'Excelﾌｧｲﾙを開く
        ExlApp = CreateObject("Excel.Application")
        ExlBook = ExlApp.Workbooks.Open(strFile)
        ExlSheet = ExlBook.Worksheets("MPロール結果")

        z = 6
        i = 6
        While ExlSheet.Range("B" & i).Value <> ""

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
            sSet = Right(ExlSheet.Range("B" & i).Value, 2)
            '要変フラグ
            sY_Flg = "F"
            '要変工程フラグ
            sYK_Flg = "F"
            '測定者
            sOpeName = "MT"

            '転送日
            sDay = Split(Left(Today, 10), "/")(0) & Split(Left(Today, 10), "/")(1) & Split(Left(Today, 10), "/")(2)
            '転送時間
            sTime = Split(Mid(Now, 12, 20), ":")(0) & Split(Mid(Now, 12, 20), ":")(1) & Split(Mid(Now, 12, 20), ":")(2)

            If Len(sTime) = 5 Then

                sTime = "0" & sTime

            End If

            '再測フラグ
            If ExlSheet.Range("B" & i).Value = ExlSheet.Range("B" & i + 1).Value Or y <> 0 Then
                sRetryFlg = y
                y = y + 1
                If ExlSheet.Range("B" & i).Value <> ExlSheet.Range("B" & i + 1).Value Then
                    y = 0
                End If
            Else
                sRetryFlg = "0"
            End If
            'REFフラグ
            If InStr(ExlSheet.Range("B" & i).Value, "REF") >= 1 Then
                sRefFlg = "1"
            Else
                sRefFlg = "0"
            End If
            'チェックフラグ
            sChkFlg = "0"

            '測定機
            sTester = Left(ExlSheet.Range("K" & i).Value, 12)

            '測定長
            sTapeLen = Left(ExlSheet.Range("J" & i).Value, 12)

            'MP上限
            sMp_U = Split(sData, ",")(0)

            'MP
            sMP = ExlSheet.Range("O" & i).Value

            z = z + 1
            'ブロックデータ
            For j = 0 To 14
                sBlockData(j) = ""
            Next j
            'B-MP上限
            sBMP_U = "0"

            'B-MP
            sBMP = ExlSheet.Range("P" & i).Value

            '90mブロック上限　※取得出来ない為、空白
            s90Block_U = ""

            '90mブロック　※取得出来ない為、空白
            s90Block = ""

            sOpeFLG = ""
            sSelectFlg = ""
            sMp_Create_Date = ""
            sMp_UPdate_Date = ""


            'Shift JISで書き込む
            '書き込むファイルが既に存在している場合は、上書きする

            Dim sw As New System.IO.StreamWriter(sTrans & sDay & sTime & "_" & sType & "_" & sLot & sRoll & "_" & sSlit & " " & sSet & ".prn") '', False, System.Text.Encoding.GetEncoding("shift_jis"))


            'TextBox1.Textの内容を書き込む
            sw.Write(sType & "," & sLot & "," & sRoll & "," & sSlit & "," & sY_Flg & "," &
            sYK_Flg & "," & sOpeName & "," & sDay & "," & sTime & "," & sRetryFlg & "," & sRefFlg & "," &
            sChkFlg & "," & sTester & "," & sTapeLen & "," & sTester & "," & sSet & "," &
            sMp_U & "," & sMP & "," & sBlockData(0) & "," & sBlockData(1) & "," & sBlockData(2) _
            & "," & sBlockData(3) & "," & sBlockData(4) & "," & sBlockData(5) & "," & sBlockData(6) _
            & "," & sBlockData(7) & "," & sBlockData(8) & "," & sBlockData(9) & "," & sBlockData(10) _
            & "," & sBMP_U & "," & sBMP _
            & "," & sOpeFLG & "," & sSelectFlg & "," & sMp_Create_Date & "," & sMp_UPdate_Date)

            System.Threading.Thread.Sleep(1000)

            '閉じる
            sw.Close()

            i = i + 1

        End While

        '変更の保存
        ExlBook.Close()
        ExlApp.Quit()

        'ExlSheetMP_Roll = Nothing
        ExlSheet = Nothing
        ExlBook = Nothing
        ExlApp = Nothing

        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlSheetMP_Roll)
        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlSheet)
        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlBook)
        'System.Runtime.InteropServices.Marshal.ReleaseComObject(ExlApp)





        'ﾀﾞﾐｰﾌｧｲﾙの削除

        System.IO.File.Delete(sTrans & "DUMMY.prn")

        'prnﾌｧｲﾙの確認
        'strFile = Dir$(sSaveData & "DUMMY.prn")
        'iPrnFileCnt = 0
        'prnﾌｧｲﾙのﾌｧｲﾙ数の確認
        'Do Until strFile = ""
        '    iPrnFileCnt = iPrnFileCnt + 1
        '    strFile = Dir$()
        'Loop
        'If iPrnFileCnt <> 0 Then
        '    Kill sSaveData & "DUMMY.prn"
        'End If



    End Sub


End Module
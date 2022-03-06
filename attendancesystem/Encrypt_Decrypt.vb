Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Module Encrypt_Decrypt
    Public Function CaesarCipher(ByVal strInput As String,
        ByVal intShift As Integer, Optional ByVal strCharacterSet _
        As String = "abcdefghijklmnopqrstuvwxyz" &
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" & "1234567890" & " ") As String
        Dim sbEncrypt As New StringBuilder With {.Capacity = strInput.Length}
        For Each c As Char In strInput
            Dim intChar As Integer = strCharacterSet.IndexOf(c)
            Do Until (intChar + intShift) < (strCharacterSet.Length)
                intChar -= strCharacterSet.Length
            Loop
            sbEncrypt.Append(strCharacterSet(intChar + intShift))
        Next c
        Return sbEncrypt.ToString
    End Function

    Public Function CaesarDecipher(ByVal strInput As String,
        ByVal intShift As Integer, Optional ByVal strCharacterSet _
        As String = "abcdefghijklmnopqrstuvwxyz" &
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" & "1234567890" & " ") As String
        Return CaesarCipher(strInput, intShift, String.Join("",
         strCharacterSet.Reverse))
    End Function
End Module

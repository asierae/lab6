Imports System.Security.Cryptography
Public Class Sha1

    Public Shared objSHA1 As New SHA1CryptoServiceProvider

    Public Shared Function getSha1(st As String) As String

        'Dim cBase64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(st))
        Dim abBytesToHash = System.Text.Encoding.ASCII.GetBytes(st)

        Dim cHash = BitConverter.ToString(objSHA1.ComputeHash(abBytesToHash))
        cHash = Replace(cHash, "-", "")
        Return cHash

    End Function

End Class

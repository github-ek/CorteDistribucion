Imports System.Security.Principal

Module Auth
    Public Function Roles() As String()
        Dim identity As WindowsIdentity = My.User.CurrentPrincipal.Identity

        For Each i As IdentityReference In identity.Groups.ToList()
            Dim x As NTAccount
            x = i.Translate(GetType(System.Security.Principal.NTAccount))
            Console.WriteLine(i.Translate(GetType(System.Security.Principal.NTAccount)).Value)
        Next
        Roles = {""}
    End Function
End Module

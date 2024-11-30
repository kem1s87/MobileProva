using System;
using UnityEngine;

[Serializable]
public class UserCreateRequest
{
    [SerializeField]
    public string username;
    [SerializeField]
    public string password;

    public string confirmPassword;

    public string Validate()
    {
        if (password != confirmPassword)
            return "Confirma��o de senha n�o corresponde";


        return "";
    }
}

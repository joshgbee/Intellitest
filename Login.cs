using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Login
{
    private int _idNumber;
    private string _loginType;
    private bool _isLoggedIn = false;
    private bool _isStudent = false;
    private bool _isTeacher = false;
    private bool _isAdmin = false;

	public Login()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public Login(int idNumber)
    {
        _idNumber = idNumber;

        switch (idNumber)
        {
            case 1:
                _loginType = "A";
                _isAdmin = true;
                break;
            case 2:
                _loginType = "T";
                _isTeacher = true;
                break;
            case 3:
                _loginType = "S";
                _isStudent = true;
                break;
            default:
                _loginType = "F";
                _isLoggedIn = false;
                break;
        }

        _isLoggedIn = true;
    }

    public int IdNumber()
    {
        return _idNumber;
    }

    public bool IsLoggedIn()
    {
        return _isLoggedIn;
    }

    public bool IsTeacher()
    {
        return _isTeacher;
    }

    public bool IsStudent()
    {
        return _isStudent;
    }

    public bool IsAdmin()
    {
        return _isAdmin;
    }

    public string loginType()
    {
        return _loginType;
    }
}

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="Registration.RegistrationForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registeration</title>
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous" />
    <link rel="stylesheet" type="text/css" href="Assets/css/Style.css" />

</head>
<body>
    <div id="main">
    <form id="form1" runat="server">
        <div class="container">
            <h1  id="title">Registration Form</h1>
            <hr />
            <br />
            <div id="input">
            <table class="w-100">
                <tr>
                    <td class="auto-style2">
                        <span>Full Name</span>
                    </td>
                    <td>
                        <input type="text" name="name" id="name" placeholder="Full Name" required class="auto-style6" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <span>Email</span>
                    </td>
                    <td>
                        <input type="email" name="email" id="email" placeholder="Email" required class="auto-style6" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <span>Password</span>
                    </td>
                    <td>
                        <input type="password" name="pass" id="password" placeholder="Password" required maxlength="10" class="auto-style7" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <span>Date Of Birth</span>
                    </td>
                    <td>
                        <input type="date" name="dob" id="dob" required class="auto-style8" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <span>Country</span>
                    </td>
                    <td>
                        <select id="country" name="D1">
                            <option value="India" selected>India</option>
                            <option value="USA">USA</option>
                            <option value="UK">UK</option>
                        </select></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <span>Gender</span>
                    </td>
                    <td>
                        <input type="radio" id="male" name="gender" value="male" checked="true" />
                        <label for="male" class="auto-style4">male</label>&nbsp;&nbsp;
                        <input type="radio" id="female" name="gender" value="female" />
                        <label for="female" class="auto-style3">female </label>
                        &nbsp;<input type="radio" id="unknown" name="gender" value="unknown" />
                        <label for="unknown">unknown</label></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <span>Meal preference</span>
                    </td>
                    <td>
                        <input type="checkbox" id="calarie" name="meal" value="Low calarie" checked />
                        <label for="calarie" class="auto-style5">Low calarie</label>
                        <input type="checkbox" id="salt" name="meal" value="Low salt" />
                        <label for="salt">Low salt</label></td>
                </tr>
                <tr>
                    <td class="auto-style2" align="right">
                        <input class="btn btn-danger" type="reset" id="cancel" value="cancel" /></td>
                    <td>&nbsp;
                        <input class="btn btn-primary" type="button" id="submit" value="submit" onclick="validate()" />
                        <input class="btn btn-primary" type="button" id="time" value="Time" onclick="getTime()" />
                    </td>
                </tr>
            </table>
            <div id="output"style="margin-top: 20px;">
                <h2 id="timenow"></h2>
            </div>

            </div>
        </div>
    </form>
    </div>

    <div id="result">
        <h2 style="margin-top: 25px;">User Entered Details</h2><hr />

        <div id="divForminfo" style="margin-left: 25px;">
        </div>


    </div>

    
</body>
</html>


<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

<script src="https://code.jquery.com/jquery-3.6.1.min.js" integrity="sha256-o88AwQnZB+VDvE9tvIXrMQaPlFFSUTR+nldQm1LuPXQ=" crossorigin="anonymous"></script>
<script src="https://code.jquery.com/jquery-3.6.1.js" integrity="sha256-3zlB5s2uwoUzrXK3BT7AX3FyvojsraNFxCc2vC/7pNI=" crossorigin="anonymous"></script>

<script src="https://code.jquery.com/ui/1.13.2/jquery-ui.js" integrity="sha256-xLD7nhI62fcsEZK2/v8LsBcb4lG7dgULkuXoXB/j91c=" crossorigin="anonymous"></script>
<script src="https://code.jquery.com/ui/1.13.2/jquery-ui.min.js" integrity="sha256-lSjKY0/srUM9BE3dPm+c4fBo1dky2v27Gdjm2uoZaL0=" crossorigin="anonymous"></script>

<script src="Assets/js/Script.js"></script>

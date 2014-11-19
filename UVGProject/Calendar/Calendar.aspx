<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="UVGProject.Calendar.Calendar" %>

<html lang="en">
<head>
    <meta charset="utf-8">
    <title>Portal Académico - Calendario</title>
    <meta name="description" content="Portal académico de UVG">
    <meta name="author" content="UVG">
    <link rel="stylesheet" href="http://yui.yahooapis.com/pure/0.5.0/pure-min.css">
    <link rel="stylesheet" href="static/styles/style.css">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!--<script src="static/scripts/jquery-1.11.1.js"></script>
    <--<script src="static/scripts/functions.js"></script>
    <--[if lt IE 9]>
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
</head>
<body class="l-box">
    <script src="static/scripts/main.js"></script>
    <div class="login pure-g align-right">
        <div class="pure-u-3-4">
            <form class="pure-form">
                <input type="email" placeholder="Usuario">
                <input type="password" placeholder="Contraseña">
                <label for="remember">
                    <input id="remember" type="checkbox"> Recordar
                </label>
                <button type="submit" class="pure-button pure-button-primary">Ingresar</button>
            </form>
        </div>
    </div>
    <div class="pure-menu pure-menu-open pure-menu-horizontal">
        <ul>
            <li><a href="perfil.html">Perfil</a></li>
            <li><a href="cursos.html">Cursos</a></li>
            <li><a href="archivos.html">Archivos</a></li>
            <li class="pure-menu-selected"><a href="#">Calendario</a></li>
        </ul>
    </div>
    <div class="pure-g">
        <div class="pure-u-1-4">
            <input type="date" id="Calendar" />
            <a href="nuevaTarea.aspx"><button type="submit" class="pure-button" onclick="onClickB" id="CreateN"> Crear nueva tarea</button></a>
        </div>
    </div>
    <div class="pure-u-3-4">
        <form class="pure-form pure-form-aligned l-box">
            <table border="1">
                <tr>
                    <td align="center" id="Mon"> Hora <span class="DateContainer"></span></td>
                    <td align="center" id="Mon"> Mon <span class="DateContainer"><input type="date" id="MonDate" readonly="readonly" /></span></td>
                    <td align="center" id="Tue"> Tue <span class="DateContainer"><input type="date" id="TueDate" readonly="readonly" /></span></td>
                    <td align="center" id="Wen"> Wen <span class="DateContainer"><input type="date" id="WedDate" readonly="readonly" /></span></td>
                    <td align="center" id="Thu"> Thu <span class="DateContainer"><input type="date" id="ThuDate" readonly="readonly" /></span></td>
                    <td align="center" id="Fri"> Fri <span class="DateContainer"><input type="date" id="FriDate" readonly="readonly" /></span></td>
                    <td align="center" id="Sat"> Sat <span class="DateContainer"><input type="date" id="SatDate" readonly="readonly" /></span></td>
                    <td align="center" id="Sun"> Sun <span class="DateContainer"><input type="date" id="SunDate" readonly="readonly" /></span></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>12 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>1 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>2 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>3 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>4 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>5 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>6 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>7 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>8 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>9 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>10 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>11 am</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>12 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>1 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>2 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>3 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>4 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>5 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>6 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>7 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>8 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <tr>
                    <td align="center" width='186' height='100 '>9 pm</td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                    <td align="center" width='186' height='100 '></td>
                </tr>
                <td align="center" width='186' height='100 '>10 pm</td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                </TR>
                <td align="center" width='186' height='100 '>11 pm</td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                <td align="center" width='186' height='100 '></td>
                </TR>
            </table>
        </form>
    </div>

</body>
</html>
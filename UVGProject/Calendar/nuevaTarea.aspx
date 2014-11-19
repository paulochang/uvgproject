<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="nuevaTarea.aspx.cs" Inherits="UVGProject.Calendar.nuevaTarea" %>

<!doctype html>

<html lang="en">
<head>
    <meta charset="utf-8">

    <title>Portal Académico - Crear nueva tarea </title>
    <meta name="description" content="Portal académico de UVG">
    <meta name="author" content="UVG">
    <link rel="stylesheet" href="http://yui.yahooapis.com/pure/0.5.0/pure-min.css">
    <link rel="stylesheet" href="static/styles/style.css">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!--[if lt IE 9]>
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
</head>

<body class="l-box">
    <script src="static/scripts/main.js"></script>
    <div class="login pure-g align-right">
        <div class="pure-u-3-4">
            <form class="pure-form">
                    <input type="email" placeholder="Usuario">
                    <input type="password" placeholder="Constraseña">

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
        <div class="pure-u-3-4">
            <form class="pure-form pure-form-aligned l-box">
			<div class = "login">
			<button type="submit" class="pure-button button-error" onclick ="clickSave">Guardar</button>
			<a href="calendar.html" class="pure-button">Cancelar</a>
			</div>
                <div class="l-box">
					<div class="pure-control-group">
						<label for="Name">Nombre de la tarea: </label>
						<input id="Name_" required type="text">
					</div>
					<div class="pure-control-group">
						<label for="Name">Curso: </label>
						<select> class="pure-control-group">
							<option value="programacionbasica">Programación Básica</option>
							<option value="sociologia">Sociología</option>
							<option value="tallerCarrera">Taller de la Carrera</option>
							<option value="psicologia">Psicología</option>
						</select>
					</div>
					<div class="pure-control-group">
						<label for="Date">Fecha de la tarea: </label>
						<input type="date" ID = "Date"/>
					</div>
					<div class="pure-control-group">
						<label for="Description">Descripcion: </label>
						<input id="Description" required type="text">
					</div>
					<div class="pure-control-group">
						<label for="Description">Color de tarea: </label>
						<input type="color">
					</div>
				</div>

            </form>
        </div>
</div>
</body>
</html>
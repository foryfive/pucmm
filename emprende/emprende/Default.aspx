<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="emprende.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>

     <%--   js--%>
    <script src="js/jquery-2.2.4.min.js"></script>
    <script src="js/notify.js"></script>
    <script src="bootstrap-3.3.6-dist/js/bootstrap.min.js"></script>
   
   <%-- css--%>
    <link href="bootstrap-3.3.6-dist/css/bootstrap.min.css" rel="stylesheet" />
   <style>
       .btn-primary {
          color: #fff;
          background-color:#13292f;
          border-color: #2e6da4;
        }
    .btn-primary:hover {
      color: #fff;
      background-color:#345963;
      border-color: #204d74;
    }
    .btn-primary.active {
  background-color: #265a88;
  border-color: #245580;
}
    .logo{
     height: 52px;
     width: 52px;
    }
    h1{
     margin-top: 2px!important;
     margin-bottom: 10px!important;
    }
    .modal-header {
      padding: 15px;
      border-bottom: none;
    }
    .modal-footer {
  padding: 15px;
  text-align: right;
  border-top: none;
}

   </style>


<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:rgb(11, 67, 80);" >
    <form id="form1" runat="server">
    
        <div id="loginModal" class="modal show" tabindex="-1" role="dialog" aria-hidden="true">
  <div class="modal-dialog">
  <div class="modal-content" style="border-radius: 32px 1px;" >
      <div class="modal-header">
          <img src="Recursos/pucmmlogo.png" class="logo" alt="Alternate Text" />
          <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
          <h1 class="text-center">Iniciar Sesión</h1>
      </div>
      <div class="modal-body">
          <div class="form col-md-12 center-block">
            <div class="form-group">
              <input type="text" class="form-control input-lg" runat="server" id="txtusuario" required="true" placeholder="Usuario"/>
            </div>
            <div class="form-group">
              <input type="password" class="form-control input-lg" runat="server" id="txtclave" required="true" placeholder="Clave"/>
            </div>
            <div class="form-group">
                <asp:Button CssClass="btn btn-primary btn-lg btn-block" Text="Iniciar" OnClick="btniniciar_Click" ID="btniniciar" runat="server" />  
              <a href="#">Necesita ayuda?</a>
            </div>
          </div>
      </div>
      <div class="modal-footer">
		  </div>	        
      </div>
  </div>
  </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="emprende.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="">

<div id="myCarousel" class="carousel slide visible-md visible-md  visible-lg" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active" style="height:300px;" > 
      <img src="Imagenes/1.jpg" style="height:100%;width:100%;" alt="Chania"/>
    </div>

    <div class="item" style="height:300px;">
      <img src="Imagenes/2.jpg"  style="width:100%;" alt="Flower"/>
    </div>

    <div class="item" style="height:300px;">
      <img src="Imagenes/3.jpg" style="height:100%;width:100%;" alt="Flower"/>
    </div>
  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
</div>    
 <br/>   
 <br/>
<div class="container con">
    <h2>Últimos Proyectos</h2>
    <div class="col-md-8">
     <div runat="server" id="divcontenido" class="">
     </div> <%--fin container--%>  
    </div>
    <div class="col-md-3 col-md-offset-1 visible-lg visible-md  ">
       <div class="row well">
           <asp:TextBox placeholder="Texto a buscar" runat="server" CssClass="form-control" /><br/>
           <asp:LinkButton  runat="server" CssClass="btn btn-success"  ><span class="glyphicon glyphicon-search " ></span> Buscar</asp:LinkButton>
       </div>  
    </div>
</div>


</asp:Content>

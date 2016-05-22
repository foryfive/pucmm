<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Persona.aspx.cs" Inherits="emprende.Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/persona.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

      <div class="container">
      <div class="col-md-10 col-md-offset-1 ">
        <div class="page-header">
            <h2>Mantenimiento Usuario</h2>
        </div>
     <div class="form-horizontal">

         <div class="form-group">
            <div class="col-md-3">
              <label>ID</label>
              <asp:TextBox runat="server" CssClass="form-control" ID="txtid" ReadOnly="true" />            
            </div>
         </div>
         <div class="form-group">
              <div class="col-md-4">
                 <label>Cédula</label>
                 <asp:TextBox runat="server" CausesValidation="true" CssClass="form-control" required="required" ID="txtcedula" MaxLength="15" />                 
             </div> 
             <div class="col-md-8">
                 <label>Nombre</label>
                 <asp:TextBox runat="server" CausesValidation="true" CssClass="form-control" required="required" ID="txtnombre" MaxLength="50" />                 
             </div>   
         </div>
        <div class="form-group">
              <div class="col-md-4">
                 <label>Usuario</label>
                 <asp:TextBox runat="server" CausesValidation="true" CssClass="form-control" required="required" ID="txtusuario" MaxLength="20" />                 
             </div> 
             <div class="col-md-4">
                 <label>Rol</label>
                 <asp:DropDownList ID="cmbrol" runat="server" CssClass="form-control">
                     <asp:ListItem Text="Administrador" Value="1" />
                     <asp:ListItem Text="Estudiante" value="2" />
                 </asp:DropDownList>
             </div>   
             <div class="col-md-4">
                 <label>Carrera</label>
                 <asp:DropDownList ID="cmbcarrera" Enabled ="false"  runat="server" CssClass="form-control">
                 </asp:DropDownList>
             </div>   
         </div>
          <div class="form-group">
              <div class="col-md-4">
                 <label>Clave</label>
                 <asp:TextBox runat="server" TextMode="Password" CausesValidation="true" CssClass="form-control" required="required" ID="txtclave" MaxLength="15" />                 
             </div>             
         </div>
         <div class="form-group">
              <div class="col-md-4">
                 <label>Repita la Clave</label>
                 <asp:TextBox runat="server" TextMode="Password" CausesValidation="true" CssClass="form-control" required="required" ID="txtrepitaclave" MaxLength="15" />                 
             </div>             
         </div>

          <div runat="server" id="divbuscar" class="form-group">
             <div class="col-md-6">
                 <label>Buscar</label>
                 <asp:TextBox runat="server" CssClass="form-control" ID="txtbuscar" MaxLength="15" />
             </div>   
          </div>
         <br/>
         <asp:Panel runat="server" ID="panel" class="panel"  Height="100px" ScrollBars="Vertical" >     
               <asp:GridView ID="Grid" CssClass="table table-bordered table-striped table-hover table-responsive" runat="server" AutoGenerateColumns="False" >
                   <Columns>
                       <asp:CommandField ShowSelectButton="True" HeaderText="Seleccionar">
                       <HeaderStyle Width="100px" />
                       </asp:CommandField>
                       <asp:BoundField DataField="idpersona" HeaderText="ID">
                       <ItemStyle Width="100px" />
                       </asp:BoundField>
                       <asp:BoundField DataField="cedula" HeaderText="Cédula">
                       <ItemStyle Width="100px" />
                       </asp:BoundField>
                       <asp:BoundField DataField="nombre" HeaderText="Nombre">
                       <HeaderStyle Width="230px" />
                       </asp:BoundField>
                       <asp:BoundField DataField="usuario" HeaderText="Usuario">
                       <HeaderStyle Width="150px" />
                       </asp:BoundField>
                   </Columns>
               </asp:GridView>

         </asp:Panel>
         <br/>

         <div class="form-group">
            <div class="col-md-12">
             <asp:LinkButton runat="server" ID="btnnuevo" CssClass="btn btn-primary" OnClick="btnnuevo_Click" ><span class="glyphicon glyphicon-plus" ></span> Nuevo</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btngrabar" CssClass="btn btn-primary"  ><span class="glyphicon glyphicon-floppy-disk" ></span> Grabar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btncancelar" CssClass="btn btn-primary" OnClick="btncancelar_Click"  ><span class="glyphicon glyphicon-ban-circle" ></span> Cancelar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btnmodificar" CssClass="btn btn-primary"><span class="glyphicon glyphicon-refresh" ></span> Modificar</asp:LinkButton>
             <asp:LinkButton runat="server" ID="btneliminar" CssClass="btn btn-primary" ><span class="glyphicon glyphicon-trash" ></span> Eliminar</asp:LinkButton>
            </div>  
         </div>




      </div> <%--fin form-horizontal--%>


     </div>   

</div>

</asp:Content>

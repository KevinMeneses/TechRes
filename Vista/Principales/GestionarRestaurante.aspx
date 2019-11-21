<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.master" CodeBehind="GestionarRestaurante.aspx.cs" Inherits="TechRestaurant.GestionarRestaurante" %>

<asp:Content ContentPlaceHolderID ="cabecera" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestionar restaurante</title>
</asp:Content>

<asp:Content ContentPlaceHolderID ="contenido" runat="server">
    <div class ="col-4 offset-4">
        <div class="card">
            <div class="card-header bg-info text-white" style="text-align:center">GESTIONAR RESTAURANTE</div>
						
            <div class="card-body">

                <div id="accordion" style="margin-top: 20px;">
					<div class="card form-group">							      
                        <button type="button"  class="btn btn-outline-info btn-lg btn-block dropdown-toggle" data-toggle="collapse" href="#empleados">
								    Empleados
						</button>      
						<div id="empleados" class="collapse" data-parent="#accordion">
							<div class="card-body">
                                <asp:Button ID="btAgregarEmp" type="button" class="btn btn-link btn-lg btn-block" runat="server" OnClick="btAgregarEmp_Click" Text="Agregar empleado"></asp:Button>		
                                <asp:Button ID="btBuscarEmp" type="button" class="btn btn-link btn-lg btn-block" runat="server" OnClick="btBuscarEmp_Click" Text="Consultar empleados"></asp:Button>		
							</div>
						</div>
					</div>							                         

					<div class="card form-group">							      
                        <button type="button" class="btn btn-outline-info btn-lg btn-block dropdown-toggle" data-toggle="collapse" href="#mesas">
								    Mesas
						</button>
                        <div id="mesas" class="collapse" data-parent="#accordion">
						    <div class="card-body">
                                <asp:Button ID="btAgregarMesa" type="button" class="btn btn-link btn-lg btn-block" runat="server" Text="Agregar mesa" OnClick="btAgregarMesa_Click"></asp:Button>		
                                <asp:Button ID="btBuscarMesa" type="button" class="btn btn-link btn-lg btn-block" runat="server" Text="Consultar mesas" OnClick="btBuscarMesa_Click"></asp:Button>		
							</div>	
						</div>
					</div> 

					<div class="card form-group">							      
                        <button type="button" class="btn btn-outline-info btn-lg btn-block dropdown-toggle" data-toggle="collapse" href="#platos">
								    Platos
						</button>
                        <div id="platos" class="collapse" data-parent="#accordion">
						    <div class="card-body">                                  
                                <asp:Button ID="btAgregarPlato" runat="server" type="button" class="btn btn-link btn-lg btn-block" Text="Agregar plato" OnClick="btAgregarPlato_Click"></asp:Button>		
                                <asp:Button ID="btBuscarPlato" runat="server" type="button" class="btn btn-link btn-lg btn-block" Text="Consultar platos" OnClick="btBuscarPlato_Click"></asp:Button>
							</div>	
						</div>
					</div>    						    

					<div class="card form-group">							      
						<button type="button" class="btn btn-outline-info btn-lg btn-block dropdown-toggle" data-toggle="collapse" href="#pedidos">
								Pedidos
						</button>							      
						<div id="pedidos" class="collapse" data-parent="#accordion">
						    <div class="card-body">
                                <asp:Button ID="btAgregarPed" runat="server" type="button" class="btn btn-link btn-lg btn-block" OnClick="btAgregarPed_Click" Text="Agregar pedido"/>
                                <asp:Button ID="btBuscarPed" runat="server" type="button" class="btn btn-link btn-lg btn-block" OnClick="btBuscarPed_Click" Text="Consultar pedidos" />
							</div>	
						</div>
					</div>   						    

					<div class="card form-group">							      
						<button type="button" class="btn btn-outline-info btn-lg btn-block dropdown-toggle" data-toggle="collapse" href="#stock">
								Stock
						</button>							      
						<div id="stock" class="collapse" data-parent="#accordion">
						    <div class="card-body">
                                <asp:Button ID="btAgregarIng" runat="server" type="button" class="btn btn-link btn-lg btn-block" Text="Agregar ingrediente" OnClick="btAgregarIng_Click"/>
                                <asp:Button ID="btBuscarIng" runat="server" type="button" class="btn btn-link btn-lg btn-block" Text="Consultar stock" OnClick="btBuscarIng_Click"/>
							</div>	
						</div>
					</div>

					<div class="card form-group">							      
                        <asp:Button ID="btFacturacion" runat="server" type="button" class="btn btn-info btn-lg btn-block" OnClick="btFacturacion_Click" Text="Facturacion" />
					</div>  						    
	    
                    </div> 
                </div>
            </div>
        </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="scripts" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script> 
</asp:Content>

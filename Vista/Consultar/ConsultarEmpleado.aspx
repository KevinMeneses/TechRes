<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Maestra.master" CodeBehind="ConsultarEmpleado.aspx.cs" Inherits="TechRestaurant.ConsultarEmpleado" %>

<asp:Content ContentPlaceHolderID ="cabecera" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultar empleado</title>
</asp:Content>

<asp:Content ContentPlaceHolderID ="contenido" runat="server">

    <div class ="col-8 offset-2">
        <div class="card">
            <div class="card-header bg-info text-white" style="text-align:center">CONSULTAR EMPLEADO</div>
    
            <div class="card-body">

                <div class="form-group">
                    <div class ="col-12">

		                <div class="row" style="margin-bottom:10px; margin-top:15px">
		                    <div class ="col-12">
		                        <label for="txBuscar">Buscar empleado</label>
		                    </div>                               
		                </div>        

		                <div class ="form-row">
		                    <div class ="col-10">                                         
                                <asp:TextBox type="text" id="txBuscar" class="form-control" placeholder="Ingrese un número de identificación" runat="server"></asp:TextBox>
		                    </div>
		                    <div class ="col-auto">
                                <asp:Button type="submit" id="btBuscar" class="btn btn-info" runat="server" Text="Buscar" OnClick="btBuscar_Click"/>
		                    </div>
		                </div>  
                    </div>               
                </div>

                <div class="form-group">
                    <div class ="col-12">
		                <div class="row" style="margin-bottom:5px">
			                <div class ="col-12">
                                <asp:GridView ID="gvEmpleado" runat="server" AutoGenerateColumns="False" CssClass="col-12 table-sm table-info">
			                        <Columns>
			                            <asp:BoundField DataField="id" HeaderText="Identificación"/>
			                            <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
			                            <asp:BoundField DataField="apellido" HeaderText="Apellido"/>
			                            <asp:BoundField DataField="correo" HeaderText="Correo"/>
			                            <asp:BoundField DataField="cargo" HeaderText="Cargo"/>
			                        </Columns>
			                    </asp:GridView>
			                </div>
			            </div>
			        </div>
	            </div>

                <div class="form-group">
                    <div class ="col-12">
	                    <div class ="form-row justify-content-end">
		                    <div class ="col-3">
                                <asp:Button type="submit" id="btModificar" Enabled="false" cssClass="btn btn-warning" runat="server" Text="Modificar" OnClick="btModificar_Click" />
		                    </div>       
		                    <div class ="col-auto">
                                <asp:Button type="submit" id="btEliminar" Enabled="false" cssClass="btn btn-danger" data-toggle="modal" data-target="#advertencia" OnClientClick="return false;" runat="server" Text="Eliminar" />
		                    </div>     
		                </div>    
	                </div>  
                </div>

                <div class="row" style="margin-top:20px">
                    <div class ="col-12">
                        <asp:Label ID="lbError" runat="server" ForeColor="Red" Text=""></asp:Label>
                        <asp:Label ID="lbMensaje" runat="server" ForeColor="Green" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>     
    
    <div class="modal fade" id="advertencia" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
		<div class="modal-dialog" role="document">
		    <div class="modal-content">
			    <div class="modal-header">
			        <h5 class="modal-title" id="exampleModalLabel">Eliminar</h5>
			        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
			            <span aria-hidden="true">&times;</span>
			        </button>
			    </div>
			    <div class="modal-body">
			            ¿Está seguro que desea eliminar este empleado?
			    </div>
			    <div class="modal-footer">
			        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                    <asp:Button type="button" class="btn btn-danger" ID="btConfirmar" runat="server" OnClick="btConfirmar_Click" Text="Eliminar" />
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
</asp:Content>
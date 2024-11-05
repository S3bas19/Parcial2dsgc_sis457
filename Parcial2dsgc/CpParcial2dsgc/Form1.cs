using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadParcial2dsgc;
using ClnParcial2dsgc;

namespace CpParcial2dsgc
{
	public partial class FrmSerie : Form
	{
		private bool esNuevo = false;
		public FrmSerie()
		{
			InitializeComponent();
		}

		private void listar()
		{
			var lista = ClnSerie.listarPa(txtParametro.Text.Trim());
			dgvLista.DataSource = lista;
			dgvLista.Columns["id"].Visible = false;
			dgvLista.Columns["estado"].Visible = false;
			dgvLista.Columns["titulo"].HeaderText = "Título";
			dgvLista.Columns["sinopsis"].HeaderText = "Sinopsis";
			dgvLista.Columns["director"].HeaderText = "Director";
			dgvLista.Columns["episodios"].HeaderText = "Episodios";
			dgvLista.Columns["fechaEstreno"].HeaderText = "Fecha de estreno";
			dgvLista.Columns["tipoClasificacion"].HeaderText = "Tipo de Clasificación";
			btnEditar.Enabled = lista.Count > 0;
			btnEliminar.Enabled = lista.Count > 0;
			if (lista.Count > 0) dgvLista.Rows[0].Cells["sinopsis"].Selected = true;
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			Size = new Size(835, 457);
			txtSinopsis.Focus();
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			esNuevo = false;
			Size = new Size(835, 457);

			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			var serie = ClnSerie.obtenerUno(id);
			txtSinopsis.Text = serie.sinopsis;
			txtTitulo.Text = serie.titulo;
			txtDirector.Text = serie.director;
			dtpFechaEstreno.Text = serie.fechaEstreno.ToString("dd/MM/yy");
			nudEpisodios.Value = serie.episodios;
			cbxTipoClasificacion.Text = serie.tipoClasificacion;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			listar();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Size = new Size(835, 296);
			limpiar();
		}

		private void txtParametro_TextChanged(object sender, EventArgs e)
		{

		}

		private bool validar()
		{
			bool esValido = true;
			erpDirector.SetError(txtDirector, "");
			erpTitulo.SetError(txtTitulo, "");
			erpSinopsis.SetError(txtSinopsis, "");
			erpEpisodio.SetError(nudEpisodios, "");
			erpFechaEstreno.SetError(dtpFechaEstreno, "");
			erpTipoClasificacion.SetError(cbxTipoClasificacion, "");

			if (string.IsNullOrEmpty(txtSinopsis.Text))
			{
				esValido = false;
				erpSinopsis.SetError(txtSinopsis, "El campo sinopsis no debe estar vacio");
			}
			if (string.IsNullOrEmpty(txtTitulo.Text))
			{
				esValido = false;
				erpTitulo.SetError(txtTitulo, "El campo titulo no debe estar vacio");
			}
			if (string.IsNullOrEmpty(txtDirector.Text))
			{
				esValido = false;
				erpDirector.SetError(txtDirector, "El campo Director no debe estar vacio");
			}
			if (string.IsNullOrEmpty(nudEpisodios.Text))
			{
				esValido = false;
				erpEpisodio.SetError(nudEpisodios, "El campo episodios no debe estar vacio");
			}
			if (string.IsNullOrEmpty(dtpFechaEstreno.Text))
			{
				esValido = false;
				erpFechaEstreno.SetError(dtpFechaEstreno, "El campo fecha de estreno no debe estar vacio");
			}
			if (nudEpisodios.Value < 0)
			{
				esValido = false;
				erpEpisodio.SetError(nudEpisodios, "El campo episodios debe ser mayor a cero");
			}
			if (string.IsNullOrEmpty(cbxTipoClasificacion.Text))
			{
				esValido = false;
				erpTipoClasificacion.SetError(cbxTipoClasificacion, "El campo fecha de estreno no debe estar vacio");
			}
			return esValido;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (validar())
			{
				var serie = new Serie();
				serie.titulo = txtTitulo.Text.Trim();
				serie.director = txtDirector.Text.Trim();
				serie.sinopsis = txtSinopsis.Text.Trim();
				serie.episodios = Convert.ToInt32(nudEpisodios.Value);
				serie.fechaEstreno = DateTime.Parse(dtpFechaEstreno.Text);
				serie.tipoClasificacion = cbxTipoClasificacion.Text.Trim();

				if (esNuevo)
				{
					serie.fechaEstreno = DateTime.Now;
					serie.estado = 1;
					ClnSerie.insertar(serie);
				}
				else
				{
					int index = dgvLista.CurrentCell.RowIndex;
					serie.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
					ClnSerie.actualizar(serie);
				}
				listar();
				btnCancelar.PerformClick();
				MessageBox.Show("serie guardada correctamente", "~~2DO PARCIAL~~", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void limpiar()
		{
			txtDirector.Text = string.Empty;
			txtSinopsis.Text = string.Empty;
			txtTitulo.Text = string.Empty;
			dtpFechaEstreno.Text = string.Empty;
			nudEpisodios.Value = 0;
			cbxTipoClasificacion.Text = string.Empty;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int index = dgvLista.CurrentCell.RowIndex;
			int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
			string titulo = dgvLista.Rows[index].Cells["Titulo"].Value.ToString();
			DialogResult dialog = MessageBox.Show($"¿esta seguro que desea eliminar la serie con titulo {titulo}?", "~~2DO PARCIAL~~", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				ClnSerie.eliminar(id);
				listar();
				MessageBox.Show("Serie eliminada correctamente", "~~2DO PARCIAL~~", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) listar();
		}

		private void FrmSerie_Load(object sender, EventArgs e)
		{
			Size = new Size(835, 296);
			listar();
		}
	}
}

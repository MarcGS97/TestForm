using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
	public partial class Form1 : Form
	{
		int Consultas = 0;
		int NumConsultas = 0;
		int Tiempo = 0;
		bool Parar = true;
		int Metodo = 0;
		string url = "";
		string respuesta = "";

		SaveFileDialog GuardarArchivo = new SaveFileDialog();
		FileStream Archivo = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			CbMetodoConsulta.SelectedIndex = 0;
			TbTiempo.Text = "1000";
			Tiempo = 1000;
		}

		private async void BtnIniciar_Click(object sender, EventArgs e)
		{
			if (Parar)
			{
				NumConsultas = (int)NupConsultas.Value;
				url = TbURL.Text.Trim();
				Metodo = CbMetodoConsulta.SelectedIndex;
				TbURL.ReadOnly = true;
				Parar = false;
				var task = Tarea();
				try { task.Start(); } catch (Exception Ex) { MessageBox.Show(Ex.Message, "Error al iniciar tarea"); return; }
			}
		}

		private Task<int> Tarea()
		{
			return new Task<int>(() => {
				Funcion();
				return 1;
			});
		}

		public int GenerarNumeroAleatorio()
		{
			Random r = new Random();
			return r.Next(999, 999999999);
		}

		public string GenerarTextoAleatorio()
		{
			string texto = "";
			int r0 = 0;
			int r1 = 0;
			int r2 = 0;
			int r3 = 0;
			string[] caracteres = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J", "k", "K", "l", "L", "m", "M", "n", "N", "o", "O", "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "w", "W", "x", "X", "y", "Y", "z", "Z" };
			string[] caracteres2 = { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
			Random r = new Random();

			r0 = r.Next(0,1);
			r1 = r.Next(5, 12);

			for(int i = 0; i < r1; i++)
			{
				r2 = r.Next(0, (caracteres.Length - 1));
				r3 = r.Next(0, (caracteres2.Length - 1));
				if (r0 == 0)
				{
					texto += caracteres[r2] + caracteres2[r3];
				}
				else
				{
					texto += caracteres2[r3] + caracteres[r2];
				}
			}
			if (r0 == 1)
			{
				r3 = r.Next(0, (caracteres2.Length - 1));
				texto += caracteres2[r3];
			}

			return texto;
		}

		private async void Funcion()
		{
			HttpClient httpclient = new HttpClient();
			Dictionary<string, string> parametros = new Dictionary<string, string>();
			FormUrlEncodedContent formulario = new FormUrlEncodedContent(parametros);
			Uri uri = new Uri(url);
			string clave = "";
			string valor = "";
			Random r = new Random();
			Consultas = 0;
			string parametros_get = "";

			try
			{
				for (int i = 0; i < NumConsultas; i++)
				{
					if(parametros != null)
					{
						parametros.Clear();
					}
					httpclient = null;
					httpclient = new HttpClient();
					parametros = null;
					parametros = new Dictionary<string, string>();
					Invoke(new MethodInvoker(() =>
					{
						try
						{
							TbParametros.Clear();
						}
						catch (Exception Ex2) { }
					}));
					if (Parar)
					{
						Invoke(new MethodInvoker(() =>
						{
							try
							{
								TbURL.ReadOnly = false;
							}
							catch (Exception Ex2) { }
						}));
						return;
					}
					if (Metodo == 0)
					{
						Invoke(new MethodInvoker(() =>
						{
							TbParametros.Clear();
							try
							{
								parametros_get = "?";
								for (int j = 0; j < TablaParametros.Rows.Count - 1; j++)
								{
									clave = "";
									valor = "";
									if (TablaParametros.Rows[j].Cells[0].Value != null)
									{
										clave = TablaParametros.Rows[j].Cells[0].Value.ToString();
									}
									if (TablaParametros.Rows[j].Cells[1].Value != null)
									{
										valor = TablaParametros.Rows[j].Cells[1].Value.ToString();
										if (TablaParametros.Rows[j].Cells[4].Value != null)
										{
											if (Convert.ToBoolean(TablaParametros.Rows[j].Cells[4].Value) == true)
											{
												if (TablaParametros.Rows[j].Cells[3].Value == null)
												{
													valor = GenerarTextoAleatorio() + TablaParametros.Rows[j].Cells[1].Value.ToString();
													if (j == TablaParametros.Rows.Count - 2)
													{
														parametros_get += clave + "=" + valor;
													}
													else
													{
														parametros_get += clave + "=" + valor + "&";
													}
												}
												else
												{
													if (TablaParametros.Rows[j].Cells[3].Value.ToString() == "Texto")
													{
														valor = GenerarTextoAleatorio() + TablaParametros.Rows[j].Cells[1].Value.ToString();
														if (j == TablaParametros.Rows.Count - 2)
														{
															parametros_get += clave + "=" + valor;
														}
														else
														{
															parametros_get += clave + "=" + valor + "&";
														}
													}
													else
													{
														if (TablaParametros.Rows[j].Cells[3].Value.ToString() == "Numerico")
														{
															valor = GenerarNumeroAleatorio().ToString();
															if (j == TablaParametros.Rows.Count - 2)
															{
																parametros_get += clave + "=" + valor;
															}
															else
															{
																parametros_get += clave + "=" + valor + "&";
															}
														}
														else
														{
															valor = GenerarTextoAleatorio() + TablaParametros.Rows[j].Cells[1].Value.ToString();
															if (j == TablaParametros.Rows.Count - 2)
															{
																parametros_get += clave + "=" + valor;
															}
															else
															{
																parametros_get += clave + "=" + valor + "&";
															}
														}
													}
												}
											}
											else
											{
												valor = TablaParametros.Rows[j].Cells[1].Value.ToString();
											}
										}
									}
									else
									{
										clave = "";
										valor = "";
										if (TablaParametros.Rows[j].Cells[0].Value != null)
										{
											clave = TablaParametros.Rows[j].Cells[0].Value.ToString();
										}
										if (TablaParametros.Rows[j].Cells[1].Value == null)
										{
											valor = "";
											if (TablaParametros.Rows[j].Cells[4].Value != null)
											{
												if (Convert.ToBoolean(TablaParametros.Rows[j].Cells[4].Value) == true)
												{
													if (TablaParametros.Rows[j].Cells[3].Value == null)
													{
														valor = GenerarTextoAleatorio();
														if (j == TablaParametros.Rows.Count - 2)
														{
															parametros_get += clave + "=" + valor;
														}
														else
														{
															parametros_get += clave + "=" + valor + "&";
														}
													}
													else
													{
														if (TablaParametros.Rows[j].Cells[3].Value.ToString().Trim() == "Texto")
														{
															valor = GenerarTextoAleatorio();
															if (j == TablaParametros.Rows.Count - 2)
															{
																parametros_get += clave + "=" + valor;
															}
															else
															{
																parametros_get += clave + "=" + valor + "&";
															}
														}
														else
														{
															if (TablaParametros.Rows[j].Cells[3].Value.ToString().Trim() == "Numerico")
															{
																valor = GenerarNumeroAleatorio().ToString();
																if (j == TablaParametros.Rows.Count - 2)
																{
																	parametros_get += clave + "=" + valor;
																}
																else
																{
																	parametros_get += clave + "=" + valor + "&";
																}
															}
															else
															{
																valor = GenerarTextoAleatorio();
																if (j == TablaParametros.Rows.Count - 2)
																{
																	parametros_get += clave + "=" + valor;
																}
																else
																{
																	parametros_get += clave + "=" + valor + "&";
																}
															}
														}
													}
												}
												else
												{
													valor = TablaParametros.Rows[j].Cells[1].Value.ToString();
												}
											}
										}
									}
									parametros.Add(clave, valor);
									TbParametros.AppendText(clave + "=" + valor);
									TbParametros.AppendText(Environment.NewLine);

									TbLink.Clear();
									TbLink.Text = url + parametros_get;
								}
							}
							catch (Exception Ex2) { }
						}));

						formulario = null;
						formulario = new FormUrlEncodedContent(parametros);

						uri = new Uri(url + parametros_get);

						var response = await httpclient.GetAsync(uri);
						if (response.StatusCode == HttpStatusCode.OK)
						{
							respuesta = await response.Content.ReadAsStringAsync();
							Invoke(new MethodInvoker(() =>
							{
								try
								{
									TbRespuesta.Clear();
									TbRespuesta.Text = respuesta;
								}
								catch (Exception Ex2) { }
							}));
						}
					}
					if(Metodo == 1)
					{
						Invoke(new MethodInvoker(() =>
						{
							TbParametros.Clear();
							try
							{
								for (int j = 0; j < TablaParametros.Rows.Count - 1; j++)
								{
									clave = "";
									valor = "";

									if (TablaParametros.Rows[j].Cells[0].Value != null)
									{
										clave = TablaParametros.Rows[j].Cells[0].Value.ToString();
									}
									if (TablaParametros.Rows[j].Cells[1].Value != null)
									{
										valor = TablaParametros.Rows[j].Cells[1].Value.ToString();
										if (TablaParametros.Rows[j].Cells[4].Value != null)
										{
											if (Convert.ToBoolean(TablaParametros.Rows[j].Cells[4].Value) == true)
											{
												if (TablaParametros.Rows[j].Cells[3].Value == null)
												{
													valor = GenerarTextoAleatorio() + TablaParametros.Rows[j].Cells[1].Value.ToString();
												}
												else
												{
													if (TablaParametros.Rows[j].Cells[3].Value.ToString().Trim() == "Texto")
													{
														valor = GenerarTextoAleatorio() + TablaParametros.Rows[j].Cells[1].Value.ToString();
													}
													else
													{
														if (TablaParametros.Rows[j].Cells[3].Value.ToString().Trim() == "Numerico")
														{
															valor = GenerarNumeroAleatorio().ToString();
														}
														else
														{
															valor = GenerarTextoAleatorio() + TablaParametros.Rows[j].Cells[1].Value.ToString();
														}
													}
												}
											}
											else
											{
												valor = TablaParametros.Rows[j].Cells[1].Value.ToString();
											}
										}
									}
									else
									{
										clave = "";
										valor = "";
										if (TablaParametros.Rows[j].Cells[0].Value != null)
										{
											clave = TablaParametros.Rows[j].Cells[0].Value.ToString();
										}
										if (TablaParametros.Rows[j].Cells[1].Value == null)
										{
											valor = "";
											if (TablaParametros.Rows[j].Cells[4].Value != null)
											{
												if (Convert.ToBoolean(TablaParametros.Rows[j].Cells[4].Value) == true)
												{
													if (TablaParametros.Rows[j].Cells[3].Value == null)
													{
														valor = GenerarTextoAleatorio();
													}
													else
													{
														if (TablaParametros.Rows[j].Cells[3].Value.ToString() == "Texto")
														{
															valor = GenerarTextoAleatorio();
														}
														else
														{
															if (TablaParametros.Rows[j].Cells[3].Value.ToString() == "Numerico")
															{
																valor = GenerarNumeroAleatorio().ToString();
															}
															else
															{
																valor = GenerarNumeroAleatorio().ToString();
															}
														}
													}
												}
												else
												{
													valor = TablaParametros.Rows[j].Cells[1].Value.ToString();
												}
											}
										}
									}
									parametros.Add(clave, valor);
									TbParametros.AppendText(clave + "=" + valor);
									TbParametros.AppendText(Environment.NewLine);

									TbLink.Clear();
									TbLink.Text = url;
								}
							}
							catch (Exception Ex2) { }
						}));

						formulario = null;
						formulario = new FormUrlEncodedContent(parametros);

						var response = await httpclient.PostAsync(url, formulario);
						if (response.StatusCode == HttpStatusCode.OK)
						{
							respuesta = await response.Content.ReadAsStringAsync();
							Invoke(new MethodInvoker(() =>
							{
								try
								{
									TbRespuesta.Clear();
									TbRespuesta.Text = respuesta;
								}
								catch (Exception Ex2) { }
							}));
						}
					}
					Thread.Sleep((int)Tiempo);
					++Consultas;
					Invoke(new MethodInvoker(() =>
					{
						try
						{
							LbConsultas.Text = "Consultas: " + Consultas.ToString();
						}
						catch (Exception Ex2) { }
					}));
					if (Parar)
					{
						Invoke(new MethodInvoker(() =>
						{
							try
							{
								TbURL.ReadOnly = false;
							}
							catch (Exception Ex2) { }
						}));
						return;
					}
				}
				Invoke(new MethodInvoker(() =>
				{
					try
					{
						TbURL.ReadOnly = false;
					}
					catch (Exception Ex2) { }
				}));
				Parar = true;
			}
			catch (Exception Ex1)
			{
				Invoke(new MethodInvoker(() =>
				{
					try
					{
						TbURL.ReadOnly = false;
					}
					catch (Exception Ex2) { }
				}));
				Parar = true;
			}
			Invoke(new MethodInvoker(() =>
			{
				try
				{
					TbURL.ReadOnly = false;
				}
				catch (Exception Ex2) { }
			}));
			Parar = true;
		}

		private async void BtnParar_Click(object sender, EventArgs e)
		{
			TbURL.ReadOnly = false;
			Parar = true;
		}

		private void TbTiempo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsControl(e.KeyChar))
			{
				e.Handled = false;
			}
			else if (Char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				e.Handled = true;
			}
			if(TbTiempo.Text.Trim().Length > 0)
			{
				Tiempo = Convert.ToInt32(TbTiempo.Text);
			}
		}

		private void BtnExportar_Click(object sender, EventArgs e)
		{
			Configuracion config = new Configuracion();
			config.url = TbURL.Text;
			config.method = CbMetodoConsulta.SelectedIndex;
			config.time = Convert.ToInt64(TbTiempo.Text);
			config.queries = Convert.ToInt64(NupConsultas.Value.ToString());
			for (int i = 0; i < TablaParametros.Rows.Count - 1; i++)
			{
				Parameters p = new Parameters();
				p.key = TablaParametros.Rows[i].Cells[0].Value != null ? TablaParametros.Rows[i].Cells[0].Value.ToString() : "";
				p.value = TablaParametros.Rows[i].Cells[1].Value != null ? TablaParametros.Rows[i].Cells[1].Value.ToString() : "";
				p.description = TablaParametros.Rows[i].Cells[2].Value != null ? TablaParametros.Rows[i].Cells[2].Value.ToString() : "";
				p.type_text = TablaParametros.Rows[i].Cells[3].Value != null ? TablaParametros.Rows[i].Cells[3].Value.ToString() : "";
				p.random_text = TablaParametros.Rows[i].Cells[4].Value != null ? "y" : "n";
				config.parameters.Add(p);
			}
			string configString = JsonConvert.SerializeObject(config);
			TbRespuesta.Text = configString;

			byte[] myByte = System.Text.Encoding.UTF8.GetBytes(configString);
			string myBase64 = Convert.ToBase64String(myByte);

			TbRespuesta.Text = configString;

			string nombre = "Productos Odoo";

			try
			{
				GuardarArchivo = new SaveFileDialog();
				GuardarArchivo.Filter = "Archivo de TestForm (*.tf)|*.tf";
				GuardarArchivo.RestoreDirectory = false;

				if (GuardarArchivo.ShowDialog() == DialogResult.OK)
				{
					if (GuardarArchivo.FileName != "")
					{
						nombre = GuardarArchivo.FileName;
						StreamWriter sw = new StreamWriter(nombre);
						sw.Write(myBase64);
						sw.Close();
					}
				}
				else
				{
					return;
				}
			}
			catch (Exception Ex2) { }
		}

		private void BtnImportar_Click(object sender, EventArgs e)
		{
			Configuracion conf = new Configuracion();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			string f = "";
			string c = "";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				f = openFileDialog.FileName;
			}

			try
			{
				StreamReader sr = new StreamReader(f);
				string line = sr.ReadLine();
				c = line;
				while (line != null)
				{
					try
					{
						line = sr.ReadLine();
						if(line != null)
						{
							c = line;
						}
					}catch(Exception Ex2) { }
				}
				sr.Close();
			}catch(Exception Ex1) {
				MessageBox.Show(Ex1.ToString());
			}

			bool r = false;
			try
			{
				byte[] myBase64ret = Convert.FromBase64String(c);
				string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
				conf = JsonConvert.DeserializeObject<Configuracion>(myStr);
				TbRespuesta.Text = f;
				if(conf != null)
				{
					TbURL.Text = conf.url;
					CbMetodoConsulta.SelectedIndex = Convert.ToInt32(conf.method);
					TbTiempo.Text = conf.time.ToString();
					NupConsultas.Value = conf.queries;

					for (int i = 0; i < conf.parameters.Count; i++)
					{
						DataGridViewComboBoxColumn dg = new DataGridViewComboBoxColumn();
						dg.ValueMember = conf.parameters[i].type_text;
						r = conf.parameters[i].random_text == "true" ? true : false;
						TablaParametros.Rows.Add(
							conf.parameters[i].key,
							conf.parameters[i].value,
							conf.parameters[i].description,
							null,
							null
						);
					}
				}
			}catch(Exception Ex1) {
				MessageBox.Show(Ex1.ToString());
			}
		}
	}
}

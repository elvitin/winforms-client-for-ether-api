namespace AppForm.Formularios
{
  internal class FormsControl
  {
    public static void Excluir(EtherAPI.Control.IControl controlObj, DataGridView dgv, Action refreshListMethod)
    {
      DataGridViewSelectedRowCollection rows = dgv.SelectedRows;
      if (rows.Count == 0) return;
      if (rows.Count > 1)
      {
        MessageBox.Show("Selecione apenas uma linha!");
        return;
      }

      int id = int.Parse(rows[0].Cells[0].Value.ToString());
      if (!controlObj.Excluir(id))
        MessageBox.Show("Falha ao deletar!");
      refreshListMethod();
    }
  }
}

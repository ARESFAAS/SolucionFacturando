using Facturando.Data;
using Facturando.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturando
{
    public partial class Configuracion : BaseForm
    {
        IConfiguration _configuration = new ConfigurationData();

        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            loadConfigurationSystem();
            loadTaxes();
            loadIdentificationTypes();
            loadLocations();
            loadUnitMeasures();
        }

        private void dtgConfiguracion_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgImpuestos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgTiposIdentificacion_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgUnidadesMedida_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgLocalizacionInventario_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dtgConfiguracion_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.IsNewRow)
            {
                ((List<ConfigurationModel>)((BindingSource)dtgConfiguracion.DataSource).DataSource)[e.Row.Index - 1].Id = Guid.NewGuid();
                ((List<ConfigurationModel>)((BindingSource)dtgConfiguracion.DataSource).DataSource)[e.Row.Index - 1].IsNewRegister = true;

                dtgConfiguracion.Rows[e.Row.Index - 1].Cells["IdCurrency"].Value =
                    ((List<CurrencyTypeModel>)((DataGridViewComboBoxColumn)(dtgConfiguracion.Columns["CurrencyList"])).DataSource).FirstOrDefault().Id;
                dtgConfiguracion.Rows[e.Row.Index - 1].Cells["IdCountry"].Value =
                    ((List<CountryModel>)((DataGridViewComboBoxColumn)(dtgConfiguracion.Columns["CountryList"])).DataSource).FirstOrDefault().Id;
            }
        }

        private void dtgImpuestos_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.IsNewRow)
            {
                ((List<TaxModel>)((BindingSource)dtgImpuestos.DataSource).DataSource)[e.Row.Index - 1].Id = Guid.NewGuid();
                ((List<TaxModel>)((BindingSource)dtgImpuestos.DataSource).DataSource)[e.Row.Index - 1].IsNewRegister = true;
            }
        }

        private void dtgTiposIdentificacion_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.IsNewRow)
            {
                ((List<IdentificationTypeModel>)((BindingSource)dtgTiposIdentificacion.DataSource).DataSource)[e.Row.Index - 1].Id = Guid.NewGuid();
                ((List<IdentificationTypeModel>)((BindingSource)dtgTiposIdentificacion.DataSource).DataSource)[e.Row.Index - 1].IsNewRegister = true;
            }
        }

        private void dtgUnidadesMedida_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.IsNewRow)
            {
                ((List<UnitMeasureModel>)((BindingSource)dtgUnidadesMedida.DataSource).DataSource)[e.Row.Index - 1].Id = Guid.NewGuid();
                ((List<UnitMeasureModel>)((BindingSource)dtgUnidadesMedida.DataSource).DataSource)[e.Row.Index - 1].IsNewRegister = true;
            }
        }

        private void dtgLocalizacionInventario_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.IsNewRow)
            {
                ((List<InventoryLocationModel>)((BindingSource)dtgLocalizacionInventario.DataSource).DataSource)[e.Row.Index - 1].Id = Guid.NewGuid();
                ((List<InventoryLocationModel>)((BindingSource)dtgLocalizacionInventario.DataSource).DataSource)[e.Row.Index - 1].IsNewRegister = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BindingSource configurationSource = new BindingSource();
            configurationSource.DataSource = _configuration
                .SaveConfiguration(((List<ConfigurationModel>)((BindingSource)dtgConfiguracion
                .DataSource)
                .DataSource));
            dtgConfiguracion.DataSource = configurationSource;

            BindingSource taxSource = new BindingSource();
            taxSource.DataSource = _configuration
                .SaveTax(((List<TaxModel>)((BindingSource)dtgImpuestos
                .DataSource)
                .DataSource));
            dtgImpuestos.DataSource = taxSource;

            BindingSource identificationSource = new BindingSource();
            identificationSource.DataSource = _configuration
                .SaveIdentificationType(((List<IdentificationTypeModel>)((BindingSource)dtgTiposIdentificacion
                .DataSource)
                .DataSource));
            dtgTiposIdentificacion.DataSource = identificationSource;

            BindingSource locationSource = new BindingSource();
            locationSource.DataSource = _configuration
                .SaveInventoryLocation(((List<InventoryLocationModel>)((BindingSource)dtgLocalizacionInventario
                .DataSource)
                .DataSource));
            dtgLocalizacionInventario.DataSource = locationSource;

            BindingSource unitSource = new BindingSource();
            unitSource.DataSource = _configuration
                .SaveUnitMeasure(((List<UnitMeasureModel>)((BindingSource)dtgUnidadesMedida
                .DataSource)
                .DataSource));
            dtgUnidadesMedida.DataSource = unitSource;
        }

        private void loadConfigurationSystem()
        {
            BindingSource configurationSource = new BindingSource();
            configurationSource.DataSource = _configuration.GetConfigurationList();
            dtgConfiguracion.DataSource = configurationSource;
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CurrencyList"])
                .DataSource = _configuration.GetCurrencyList();
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CurrencyList"])
               .DisplayMember = "Description";
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CurrencyList"])
               .ValueMember = "Id";
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CurrencyList"])
               .DataPropertyName = "IdCurrency";
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CountryList"])
               .DataSource = _configuration.GetCountryList();
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CountryList"])
               .DisplayMember = "Description";
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CountryList"])
               .ValueMember = "Id";
            ((DataGridViewComboBoxColumn)dtgConfiguracion.Columns["CountryList"])
               .DataPropertyName = "IdCountry";
        }

        private void loadTaxes()
        {
            BindingSource taxesSource = new BindingSource();
            taxesSource.DataSource = _configuration.GetTaxList();
            dtgImpuestos.DataSource = taxesSource;            
        }

        private void loadIdentificationTypes()
        {
            BindingSource identificationSource = new BindingSource();
            identificationSource.DataSource = _configuration.GetIdentificationTypeList();
            dtgTiposIdentificacion.DataSource = identificationSource;
        }

        private void loadLocations()
        {
            BindingSource locationSource = new BindingSource();
            locationSource.DataSource = _configuration.GetInventoryLocationList();
            dtgLocalizacionInventario.DataSource = locationSource;
        }

        private void loadUnitMeasures()
        {
            BindingSource unitSource = new BindingSource();
            unitSource.DataSource = _configuration.GetUnitMeasureList();
            dtgUnidadesMedida.DataSource = unitSource;
        }
    }
}

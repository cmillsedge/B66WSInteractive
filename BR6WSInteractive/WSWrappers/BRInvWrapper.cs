using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Model;
using BR.Inv.Model;
using BR.Inv.Api;



namespace BR6WSInteractive
{
     public class BRInvWrapper
    {
        private Session _session;
        private string _url;
        public BRInvWrapper(Session session, string url)
        {
            _session = session;
            _url = url;
        }
        public BRInvWrapper()
        {
        }

        public Container GetContainer(string containerName)
        {
            ContainerApi containersApi = new ContainerApi();
            Container myContainer = containersApi.ContainerFind(_session.SessionKey, containerName);
            return myContainer;
        }

        

        public Container CreateContainer(Container myContainer)
        {
            ContainerApi containersApi = new ContainerApi();
            Container newContainer = containersApi.ContainerCreate(_session.SessionKey, myContainer);
            return newContainer;
        }

        public BR.Inv.Model.JobReport CreateContainersBulk(ContainerBulk myContainers)
        {
            ContainerApi containersApi = new ContainerApi();
            BR.Inv.Model.JobReport jb = containersApi.ContainerUpload(_session.SessionKey, myContainers);
            return jb;
        }

        public Container UpdateContainerDescription(string containerName, Container myContainer)
        {
            ContainerApi containersApi = new ContainerApi();
            Container newContainer = containersApi.ContainerEdit(_session.SessionKey,containerName, myContainer);
            return newContainer;
        }

        public Container UpdateContainer(string containerName, Container myContainer)
        {
            ContainerApi containersApi = new ContainerApi();
            Container newContainer = containersApi.ContainerEdit(_session.SessionKey, containerName, myContainer);
            return newContainer;
        }

        public void BinContainer(string containerName)
        {
            ContainerApi containersApi = new ContainerApi();
            containersApi.ContainerMove (_session.SessionKey, containerName, "Bin","A1");
        }

        public void MoveContainer(string cont, string Location, string slot)
        {
            ContainerApi contAPI = new ContainerApi();
            contAPI.ContainerMove(_session.SessionKey, cont, Location, slot);
        }

        public void ProtectContainer(string cont, string protector, string protectionType)
        {
            ContainerApi contAPI = new ContainerApi();
            contAPI.ContainerProtect(_session.SessionKey, cont, protector, protectionType);
        }

        public void SolvateContainer(string cont, string tubeTypeName, double volume, double concentration, string concUnit, string solventName, int solventConc)
        {
            ContainerApi contAPI = new ContainerApi();
            contAPI.ContainerSolvate(_session.SessionKey, cont, tubeTypeName, volume, concentration, concUnit, solventName, solventConc);
        }

        public SampleTypeArray GetAllSampleTypes()
        {
            SampleTypesApi sampAPI = new SampleTypesApi();
            SampleTypeArray myTypes = sampAPI.SampleTypes(_session.SessionKey);              
            return myTypes;
        }

        public SampleType GetSampleType(string sampleTypeName)
        {
            SampleTypesApi sampAPI = new SampleTypesApi();
            SampleType sType = sampAPI.SampleTypeFind(_session.SessionKey, sampleTypeName);
            return sType;
        }

        public MaterialRecipe GetRecipe(string recipeName)
        {
            MaterialApi materialApi = new MaterialApi();
            MaterialRecipe rec = materialApi.MaterialRecipeFind(_session.SessionKey, recipeName);
            return rec;
        }

        public ContainerTypeArray GetAllContainerTypes()
        {
            ContainerTypesApi containerTypesApi = new ContainerTypesApi();
            ContainerTypeArray myTypes = containerTypesApi.ContainerTypes(_session.SessionKey);
            return myTypes;
        }

        public ContainerLayoutArray GetAllContainerLayouts()
        {
            ContainerLayoutsApi containerLayApi = new ContainerLayoutsApi();
            ContainerLayoutArray myTypes = containerLayApi.ContainerLayouts(_session.SessionKey);
            return myTypes;
        }

        public Material GetMaterial(string matName)
        {
            MaterialApi materialApi = new MaterialApi();
            Material myMaterial = materialApi.MaterialFind(_session.SessionKey, matName);
            return myMaterial;
        }

        public BR.Inv.Model.JobReport MaterialUploadJob(MaterialBulk materials)
        {
            MaterialApi materialApi = new MaterialApi();
            BR.Inv.Model.JobReport jb = materialApi.MaterialUploadJob(_session.SessionKey, materials);
            return jb;
        }

        public Material MaterialUpdate(Material material)
        {
            MaterialApi materialApi = new MaterialApi();
            Material mt = materialApi.MaterialEdit(_session.SessionKey, material.Name, material);
            return mt;
        }

        public Material MaterialCreate(Material material)
        {
            MaterialApi materialApi = new MaterialApi();
            Material mt = materialApi.MaterialCreate(_session.SessionKey, material);
            return mt;
        }

        public MaterialRecipe RecipeCreate(MaterialRecipe material)
        {
            MaterialApi materialApi = new MaterialApi();
            MaterialRecipe mt = materialApi.MaterialRecipeCreate(_session.SessionKey, material);
            return mt;
        }

        public MaterialRecipeArray MaterialRecipeList(string materialType)
        {
            MaterialApi materialApi = new MaterialApi();

            MaterialRecipeArray mt = materialApi.MaterialRecipes(_session.SessionKey, materialType, 100);
            return mt;
        }

        public Material ImportExternalMaterial(string table, string materialName)
        {
            ExternalMaterialApi materialApi = new ExternalMaterialApi();
            Material myMaterial = materialApi.ExternalMaterialImport(_session.SessionKey, table, materialName);
            return myMaterial;
        }

        public Material ImportExternalMaterialJob(string table, string field, BR.Inv.Model.StringArray names)
        {
            ExternalMaterialApi materialApi = new ExternalMaterialApi();
            Material myMaterial  = materialApi.ExternalMaterialImportJob(_session.SessionKey, table, field, names);
            return myMaterial;
        }

    }
}

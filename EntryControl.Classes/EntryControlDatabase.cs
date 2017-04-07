using System;
using System.Collections.Generic;
using System.Text;
using EPV.Database;

namespace EntryControl.Classes
{
    public class EntryControlDatabase : FbDatabase
    {

        private EntryControlDatabase() : base() { }

        public EntryControlDatabase(string server, string path) : base(server, path) 
        {
            LoadStaticFields();
        }

        public EntryControlDatabase(string server, string path, string user, string pass)
            : base(server, path, user, pass)
        {
            LoadStaticFields();
        }

        private void LoadStaticFields()
        {
            using (Connection connection = OpenConnection())
            {
                LoadVehicleOwnerGroup(connection);
               
                LoadOneTimePermitState(connection);
                LoadConstantPermitState(connection);
                LoadClosedPermitState(connection);
                
                LoadMinimalDate(connection);
                LoadMovingTypes(connection);

                LoadMaterialCreatorGroup(connection);
                LoadMaterialSignerGroup(connection);
                LoadWoodCargo(connection);
                LoadEntryPointEnabledCargo(connection);
                LoadEntryPointUser(connection);

                connection.Commit();
            }
        }

        private void LoadEntryPointUser(Connection connection)
        {
            EntryPointUser = new User(int.Parse(LoadConstant(connection, "EntryPointUser")), "Сотрудник ЧОП");
        }

        private void LoadEntryPointEnabledCargo(Connection connection)
        {
            EntryPointEnabledCargoGroup = int.Parse(LoadConstant(connection, "EntryPointEnabledCargo"));
        }

        private void LoadWoodCargo(Connection connection)
        {
            int id = int.Parse(LoadConstant(connection, "woodCargo"));
            WoodCargo = new Cargo(id, "Лесоматериалы");
        }

        public string LoadConstant(string constantName)
        {
            string query = EntryControl.Resources.Query.ConstantLoad;
            QueryParameters parameters = new QueryParameters("nameVariable", constantName);
            object result = ExecuteScalar(query, parameters);

            if (result == null)
                throw new NotImplementedException(constantName + " variable");

            return (string)result;
        }

        public string LoadConstant(Connection connection, string constantName)
        {
            string query = EntryControl.Resources.Query.ConstantLoad;
            QueryParameters parameters = new QueryParameters("nameVariable", constantName);
            object result = connection.ExecuteScalar(query, parameters);

            if (result == null)
                throw new NotImplementedException(constantName + " variable");

            return (string)result;
        }


        public User ConnectedUser { get; set; }

        #region VehicleOwnerGroup - группа контрагентов-перевозчиков
        
        private static EnumerationItem vehicleOwnerGroup;

        public static EnumerationItem VehicleOwnerGroup
        {
            get { return vehicleOwnerGroup; }
        }

        private void LoadVehicleOwnerGroup(Connection connection)
        {
            int id = int.Parse(LoadConstant(connection, "vehicleOwnerGroup"));

            vehicleOwnerGroup = new EnumerationItem(id, "Перевозчик");
        }

        #endregion

        #region OneTimePermitState - Вид пропуска РАЗОВЫЙ
        
        private static EnumerationItem oneTimePermitState;

        public static EnumerationItem OneTimePermitState
        {
            get { return oneTimePermitState; }
        }

        private void LoadOneTimePermitState(Connection connection)
        {
            int id = int.Parse(LoadConstant(connection, "oneTimePermitState"));

            oneTimePermitState = new EnumerationItem(id, "Разовый");
        }

        #endregion

        #region ConstantPermitState - Вид пропуска ПОСТОЯННЫЙ
        
        private static EnumerationItem constantPermitState;

        public static EnumerationItem ConstantPermitState
        {
            get { return constantPermitState; }
        }

        private void LoadConstantPermitState(Connection connection)
        {
            int id = int.Parse(LoadConstant(connection, "constantPermitState"));

            constantPermitState = new EnumerationItem(id, "Постоянный");
        }

        #endregion

        public static EnumerationItem ClosedPermitState { get; private set; }

        private void LoadClosedPermitState(Connection connection)
        {
            try
            {
                int id = int.Parse(LoadConstant(connection, "closedPermitState"));
                ClosedPermitState = new EnumerationItem(id, "Закрытый");
            }
            catch (Exception)
            {
                throw new NotImplementedException("ClosedPermitState value");
            }
        }

        #region minimalDate
        
        private static DateTime minimalDate;

        public static DateTime MinimalDate
        {
            get { return minimalDate; }
        }

        private void LoadMinimalDate(Connection connection)
        {
            object result = connection.ExecuteScalar(EntryControl.Resources.Query.GetMinimalDate);

            if (result == null || DBNull.Value.Equals(result))
                minimalDate = DateTime.Today;
            else
                minimalDate = (DateTime)result;
        }

        #endregion

        #region Виды движений
        

        #region EntryMovingType

        private static EnumerationItem entryMovingType;

        public static EnumerationItem EntryMovingType { get { return entryMovingType; } }

        private void LoadEntryMovingType(Connection connection)
        {
            int id = int.Parse(LoadConstant(connection, "entryMoving"));
            entryMovingType = new EnumerationItem(id, EntryControl.Resources.Doc.Permit.EntryMoving);
        }
        
        #endregion

        #region ExitMovingType

        private static EnumerationItem exitMovingType;

        public static EnumerationItem ExitMovingType { get { return exitMovingType; } }

        private void LoadExitMovingType(Connection connection)
        {
            int id = int.Parse(LoadConstant(connection, "exitMoving"));
            exitMovingType = new EnumerationItem(id, EntryControl.Resources.Doc.Permit.ExitMoving);
        }
        
        #endregion

        #region CloseMovingType

        private static EnumerationItem closeMovingType;

        public static EnumerationItem CloseMovingType { get { return closeMovingType; } }

        public void LoadCloseMovingType(Connection connection)
        {
            int id = int.Parse(LoadConstant(connection, "closeMoving"));
            closeMovingType = new EnumerationItem(id, EntryControl.Resources.Doc.Permit.CloseMoving);
        }
        
        #endregion

        private void LoadMovingTypes(Connection connection)
        {
            LoadEntryMovingType(connection);
            LoadExitMovingType(connection);
            LoadCloseMovingType(connection);
        }

        #endregion

        #region MaterialCreatorGroup

        public static int MaterialCreatorGroup { get; private set; }

        private void LoadMaterialCreatorGroup(Connection connection)
        {
            MaterialCreatorGroup = int.Parse(LoadConstant(connection, "materialCreatorGroup"));
        }

        #endregion

        #region MaterialSignerGroup

        public static int MaterialSignerGroup { get; private set; }

        private void LoadMaterialSignerGroup(Connection connection)
        {
            MaterialSignerGroup = int.Parse(LoadConstant(connection, "materialSignerGroup"));
        }

        #endregion

        public static Cargo WoodCargo { get; private set; }

        public static int EntryPointEnabledCargoGroup { get; private set; }

        public static User EntryPointUser { get; private set; }
    }
}

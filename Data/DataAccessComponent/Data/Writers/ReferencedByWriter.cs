

#region using statements

using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataJuggler.DocGen.DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using DataJuggler.DocGen.ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataJuggler.DocGen.DataAccessComponent.Data.Writers
{

    #region class ReferencedByWriter
    /// <summary>
    /// This class is used for converting a 'ReferencedBy' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class ReferencedByWriter : ReferencedByWriterBase
    {

        #region Static Methods

            // *******************************************
            // Write any overrides or custom methods here.
            // *******************************************

        #endregion

    }
    #endregion

}



#region using statements

#endregion

namespace DataJuggler.DocGen.ObjectLibrary.Enumerations
{

    #region ObjectTypeEnum : int
    /// <summary>
    /// This enum is used by Parameters 
    /// </summary>
    public enum ObjectTypeEnum : int
    {
        Unknown = 0,
        Constructor = 1,
        Method = 2
    }
    #endregion

    #region ReferenceTypeEnum : int
    /// <summary>
    /// This enum is used by the ReferencedBy to indicate which type of a Reference it is.
    /// </summary>
    public enum ReferenceTypeEnum : int
    {
        Class = 1,
        Constructor = 2,
        Method = 3,
        Property = 4
    }
    #endregion

}

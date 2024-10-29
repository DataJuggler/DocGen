

#region using statements

using DataJuggler.DocGen.ObjectLibrary.Enumerations;
using System;

#endregion


namespace DataJuggler.DocGen.ObjectLibrary.BusinessObjects
{

    #region class CodeSample
    public partial class CodeSample
    {

        #region Private Variables
        private int codeType;
        private int id;
        private int parentId;
        private ObjectTypeEnum parentType;
        private int status;
        private string text;
        private bool visible;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region int CodeType
            public int CodeType
            {
                get
                {
                    return codeType;
                }
                set
                {
                    codeType = value;
                }
            }
            #endregion

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region int ParentId
            public int ParentId
            {
                get
                {
                    return parentId;
                }
                set
                {
                    parentId = value;
                }
            }
            #endregion

            #region ObjectTypeEnum ParentType
            public ObjectTypeEnum ParentType
            {
                get
                {
                    return parentType;
                }
                set
                {
                    parentType = value;
                }
            }
            #endregion

            #region int Status
            public int Status
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }
            #endregion

            #region string Text
            public string Text
            {
                get
                {
                    return text;
                }
                set
                {
                    text = value;
                }
            }
            #endregion

            #region bool Visible
            public bool Visible
            {
                get
                {
                    return visible;
                }
                set
                {
                    visible = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}

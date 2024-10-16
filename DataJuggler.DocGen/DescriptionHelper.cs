

#region using statements

using DataJuggler.UltimateHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DataJuggler.DocGen
{

    #region class DescriptionHelper
    /// <summary>
    /// This class is used to remove Xml comments from the description.
    /// </summary>
    public class DescriptionHelper
    {  
        
        #region Methods

            #region FormatDescription(string rawDescription)
            /// <summary>
            /// returns the Description
            /// </summary>
            public static string FormatDescription(string rawDescription)
            {
                // initial value
                string description = "";

                // If the rawDescription string exists
                if (TextHelper.Exists(rawDescription))
                {
                    // Trim and Remove //
                    description = rawDescription.Replace("/", "").Trim();
                }
                
                // return value
                return description;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}

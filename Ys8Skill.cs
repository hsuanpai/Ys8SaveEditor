﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_Editor
{
    public enum Ys8SkillID
    {
        SKILL_START = 0,            

        SKILL_ADOL_SP_C1,           
        SKILL_ADOL_SP_C2,           
        SKILL_ADOL_SP_C3,           
        SKILL_ADOL_SP_C4,           
        SKILL_ADOL_SP_B1,           
        SKILL_ADOL_SP_B2,
        SKILL_ADOL_SP_B3,
        SKILL_ADOL_SP_B4,
        SKILL_ADOL_SP_B5,
        SKILL_ADOL_SP_A1,
        SKILL_ADOL_SP_A2,
        SKILL_ADOL_SP_A3, 
        SKILL_ADOL_RSV_01,
        SKILL_ADOL_RSV_02,
        SKILL_ADOL_RSV_03,
        SKILL_ADOL_RSV_04,
        SKILL_ADOL_RSV_05,
        SKILL_ADOL_RSV_06,
        SKILL_ADOL_RSV_07,
        SKILL_ADOL_RSV_08,
        SKILL_ADOL_SP_C1_L2,
        SKILL_ADOL_SP_C2_L2,
        SKILL_ADOL_SP_C3_L2,
        SKILL_ADOL_SP_C4_L2,
        SKILL_ADOL_SP_B1_L2,
        SKILL_ADOL_SP_B2_L2,
        SKILL_ADOL_SP_B3_L2,
        SKILL_ADOL_SP_B4_L2, 
        SKILL_ADOL_SP_B5_L2,       
        SKILL_ADOL_SP_A1_L2,        
        SKILL_ADOL_SP_A2_L2,        
        SKILL_ADOL_SP_A3_L2,        
        SKILL_ADOL_RSV_01_L2,
        SKILL_ADOL_RSV_02_L2,       
        SKILL_ADOL_RSV_03_L2,       
        SKILL_ADOL_RSV_04_L2,       
        SKILL_ADOL_RSV_05_L2,       
        SKILL_ADOL_RSV_06_L2,       
        SKILL_ADOL_RSV_07_L2,       
        SKILL_ADOL_RSV_08_L2,       
        SKILL_ADOL_SP_C1_L3,        
        SKILL_ADOL_SP_C2_L3,        
        SKILL_ADOL_SP_C3_L3,        
        SKILL_ADOL_SP_C4_L3,        
        SKILL_ADOL_SP_B1_L3,        
        SKILL_ADOL_SP_B2_L3,        
        SKILL_ADOL_SP_B3_L3,        
        SKILL_ADOL_SP_B4_L3,        
        SKILL_ADOL_SP_B5_L3,        
        SKILL_ADOL_SP_A1_L3,       
        SKILL_ADOL_SP_A2_L3,        
        SKILL_ADOL_SP_A3_L3,        
        SKILL_ADOL_RSV_01_L3,       
        SKILL_ADOL_RSV_02_L3,       
        SKILL_ADOL_RSV_03_L3,       
        SKILL_ADOL_RSV_04_L3,       
        SKILL_ADOL_RSV_05_L3,       
        SKILL_ADOL_RSV_06_L3,       
        SKILL_ADOL_RSV_07_L3,       
        SKILL_ADOL_RSV_08_L3,       
        SKILL_ADOL_BOM1,            
        SKILL_ADOL_BOM2,            

        SKILL_LAXIA_SP_C1,          
        SKILL_LAXIA_SP_C2,          
        SKILL_LAXIA_SP_C3,         
        SKILL_LAXIA_SP_C4,         
        SKILL_LAXIA_SP_B1,        
        SKILL_LAXIA_SP_B2,        
        SKILL_LAXIA_SP_B3,        
        SKILL_LAXIA_SP_B4,          
        SKILL_LAXIA_SP_B5,       
        SKILL_LAXIA_SP_A1,        
        SKILL_LAXIA_SP_A2,        
        SKILL_LAXIA_SP_A3,         
        SKILL_LAXIA_RSV_01,         
        SKILL_LAXIA_RSV_02,        
        SKILL_LAXIA_RSV_03,      
        SKILL_LAXIA_RSV_04,       
        SKILL_LAXIA_RSV_05,      
        SKILL_LAXIA_RSV_06,      
        SKILL_LAXIA_RSV_07,        
        SKILL_LAXIA_RSV_08,      
        SKILL_LAXIA_SP_C1_L2,    
        SKILL_LAXIA_SP_C2_L2,    
        SKILL_LAXIA_SP_C3_L2,     
        SKILL_LAXIA_SP_C4_L2,     
        SKILL_LAXIA_SP_B1_L2,    
        SKILL_LAXIA_SP_B2_L2,     
        SKILL_LAXIA_SP_B3_L2,    
        SKILL_LAXIA_SP_B4_L2,      
        SKILL_LAXIA_SP_B5_L2,     
        SKILL_LAXIA_SP_A1_L2,      
        SKILL_LAXIA_SP_A2_L2,     
        SKILL_LAXIA_SP_A3_L2,      
        SKILL_LAXIA_RSV_01_L2,      
        SKILL_LAXIA_RSV_02_L2,    
        SKILL_LAXIA_RSV_03_L2,     
        SKILL_LAXIA_RSV_04_L2,   
        SKILL_LAXIA_RSV_05_L2,    
        SKILL_LAXIA_RSV_06_L2,   
        SKILL_LAXIA_RSV_07_L2,     
        SKILL_LAXIA_RSV_08_L2,     
        SKILL_LAXIA_SP_C1_L3,       
        SKILL_LAXIA_SP_C2_L3,      
        SKILL_LAXIA_SP_C3_L3,      
        SKILL_LAXIA_SP_C4_L3,       
        SKILL_LAXIA_SP_B1_L3,       
        SKILL_LAXIA_SP_B2_L3,       
        SKILL_LAXIA_SP_B3_L3,     
        SKILL_LAXIA_SP_B4_L3,
        SKILL_LAXIA_SP_B5_L3,
        SKILL_LAXIA_SP_A1_L3,
        SKILL_LAXIA_SP_A2_L3,
        SKILL_LAXIA_SP_A3_L3,
        SKILL_LAXIA_RSV_01_L3,
        SKILL_LAXIA_RSV_02_L3,
        SKILL_LAXIA_RSV_03_L3,
        SKILL_LAXIA_RSV_04_L3,
        SKILL_LAXIA_RSV_05_L3,
        SKILL_LAXIA_RSV_06_L3,
        SKILL_LAXIA_RSV_07_L3,
        SKILL_LAXIA_RSV_08_L3,
        SKILL_LAXIA_BOM1,
        SKILL_LAXIA_BOM2,

        SKILL_SAHAD_SP_C1,
        SKILL_SAHAD_SP_C2,
        SKILL_SAHAD_SP_C3,
        SKILL_SAHAD_SP_C4,      
        SKILL_SAHAD_SP_B1,
        SKILL_SAHAD_SP_B2,
        SKILL_SAHAD_SP_B3,
        SKILL_SAHAD_SP_B4,
        SKILL_SAHAD_SP_B5,
        SKILL_SAHAD_SP_A1,
        SKILL_SAHAD_SP_A2,
        SKILL_SAHAD_SP_A3,
        SKILL_SAHAD_RSV_01,
        SKILL_SAHAD_RSV_02,
        SKILL_SAHAD_RSV_03,
        SKILL_SAHAD_RSV_04,
        SKILL_SAHAD_RSV_05,
        SKILL_SAHAD_RSV_06,
        SKILL_SAHAD_RSV_07,
        SKILL_SAHAD_RSV_08,
        SKILL_SAHAD_SP_C1_L2,
        SKILL_SAHAD_SP_C2_L2,
        SKILL_SAHAD_SP_C3_L2,
        SKILL_SAHAD_SP_C4_L2,
        SKILL_SAHAD_SP_B1_L2,
        SKILL_SAHAD_SP_B2_L2,
        SKILL_SAHAD_SP_B3_L2,
        SKILL_SAHAD_SP_B4_L2,
        SKILL_SAHAD_SP_B5_L2,
        SKILL_SAHAD_SP_A1_L2,
        SKILL_SAHAD_SP_A2_L2,
        SKILL_SAHAD_SP_A3_L2,
        SKILL_SAHAD_RSV_01_L2,
        SKILL_SAHAD_RSV_02_L2,
        SKILL_SAHAD_RSV_03_L2,
        SKILL_SAHAD_RSV_04_L2,
        SKILL_SAHAD_RSV_05_L2,
        SKILL_SAHAD_RSV_06_L2,
        SKILL_SAHAD_RSV_07_L2,
        SKILL_SAHAD_RSV_08_L2,
        SKILL_SAHAD_SP_C1_L3,
        SKILL_SAHAD_SP_C2_L3,
        SKILL_SAHAD_SP_C3_L3,
        SKILL_SAHAD_SP_C4_L3,
        SKILL_SAHAD_SP_B1_L3,
        SKILL_SAHAD_SP_B2_L3,
        SKILL_SAHAD_SP_B3_L3,
        SKILL_SAHAD_SP_B4_L3,
        SKILL_SAHAD_SP_B5_L3,
        SKILL_SAHAD_SP_A1_L3,
        SKILL_SAHAD_SP_A2_L3,
        SKILL_SAHAD_SP_A3_L3,
        SKILL_SAHAD_RSV_01_L3,
        SKILL_SAHAD_RSV_02_L3,
        SKILL_SAHAD_RSV_03_L3,
        SKILL_SAHAD_RSV_04_L3,
        SKILL_SAHAD_RSV_05_L3,
        SKILL_SAHAD_RSV_06_L3,
        SKILL_SAHAD_RSV_07_L3,
        SKILL_SAHAD_RSV_08_L3,
        SKILL_SAHAD_BOM1,
        SKILL_SAHAD_BOM2,

        SKILL_HUMMEL_SP_C1,
        SKILL_HUMMEL_SP_C2,
        SKILL_HUMMEL_SP_C3,
        SKILL_HUMMEL_SP_C4,
        SKILL_HUMMEL_SP_B1,
        SKILL_HUMMEL_SP_B2,
        SKILL_HUMMEL_SP_B3,
        SKILL_HUMMEL_SP_B4,
        SKILL_HUMMEL_SP_B5,
        SKILL_HUMMEL_SP_A1,
        SKILL_HUMMEL_SP_A2,
        SKILL_HUMMEL_SP_A3,
        SKILL_HUMMEL_RSV_01,
        SKILL_HUMMEL_RSV_02,
        SKILL_HUMMEL_RSV_03,
        SKILL_HUMMEL_RSV_04,
        SKILL_HUMMEL_RSV_05,
        SKILL_HUMMEL_RSV_06,
        SKILL_HUMMEL_RSV_07,
        SKILL_HUMMEL_RSV_08,
        SKILL_HUMMEL_SP_C1_L2,
        SKILL_HUMMEL_SP_C2_L2,
        SKILL_HUMMEL_SP_C3_L2,
        SKILL_HUMMEL_SP_C4_L2,
        SKILL_HUMMEL_SP_B1_L2,
        SKILL_HUMMEL_SP_B2_L2,
        SKILL_HUMMEL_SP_B3_L2,
        SKILL_HUMMEL_SP_B4_L2,
        SKILL_HUMMEL_SP_B5_L2,
        SKILL_HUMMEL_SP_A1_L2,
        SKILL_HUMMEL_SP_A2_L2,
        SKILL_HUMMEL_SP_A3_L2,
        SKILL_HUMMEL_RSV_01_L2,
        SKILL_HUMMEL_RSV_02_L2,
        SKILL_HUMMEL_RSV_03_L2,
        SKILL_HUMMEL_RSV_04_L2,
        SKILL_HUMMEL_RSV_05_L2,
        SKILL_HUMMEL_RSV_06_L2,
        SKILL_HUMMEL_RSV_07_L2,
        SKILL_HUMMEL_RSV_08_L2,
        SKILL_HUMMEL_SP_C1_L3,
        SKILL_HUMMEL_SP_C2_L3,
        SKILL_HUMMEL_SP_C3_L3,
        SKILL_HUMMEL_SP_C4_L3,
        SKILL_HUMMEL_SP_B1_L3,
        SKILL_HUMMEL_SP_B2_L3,
        SKILL_HUMMEL_SP_B3_L3,
        SKILL_HUMMEL_SP_B4_L3,
        SKILL_HUMMEL_SP_B5_L3,
        SKILL_HUMMEL_SP_A1_L3,
        SKILL_HUMMEL_SP_A2_L3,
        SKILL_HUMMEL_SP_A3_L3,
        SKILL_HUMMEL_RSV_01_L3,
        SKILL_HUMMEL_RSV_02_L3,
        SKILL_HUMMEL_RSV_03_L3,
        SKILL_HUMMEL_RSV_04_L3,
        SKILL_HUMMEL_RSV_05_L3,
        SKILL_HUMMEL_RSV_06_L3,
        SKILL_HUMMEL_RSV_07_L3,
        SKILL_HUMMEL_RSV_08_L3,
        SKILL_HUMMEL_BOM1,
        SKILL_HUMMEL_BOM2,

        SKILL_RICOTTA_SP_C1,
        SKILL_RICOTTA_SP_C2,
        SKILL_RICOTTA_SP_C3,
        SKILL_RICOTTA_SP_C4,
        SKILL_RICOTTA_SP_B1,
        SKILL_RICOTTA_SP_B2,
        SKILL_RICOTTA_SP_B3,
        SKILL_RICOTTA_SP_B4,
        SKILL_RICOTTA_SP_B5,
        SKILL_RICOTTA_SP_A1,
        SKILL_RICOTTA_SP_A2,
        SKILL_RICOTTA_SP_A3,
        SKILL_RICOTTA_RSV_01,
        SKILL_RICOTTA_RSV_02,
        SKILL_RICOTTA_RSV_03,
        SKILL_RICOTTA_RSV_04,
        SKILL_RICOTTA_RSV_05,
        SKILL_RICOTTA_RSV_06,
        SKILL_RICOTTA_RSV_07,
        SKILL_RICOTTA_RSV_08,
        SKILL_RICOTTA_SP_C1_L2,
        SKILL_RICOTTA_SP_C2_L2,
        SKILL_RICOTTA_SP_C3_L2,
        SKILL_RICOTTA_SP_C4_L2,
        SKILL_RICOTTA_SP_B1_L2,
        SKILL_RICOTTA_SP_B2_L2,
        SKILL_RICOTTA_SP_B3_L2,
        SKILL_RICOTTA_SP_B4_L2,
        SKILL_RICOTTA_SP_B5_L2,
        SKILL_RICOTTA_SP_A1_L2,
        SKILL_RICOTTA_SP_A2_L2,
        SKILL_RICOTTA_SP_A3_L2,
        SKILL_RICOTTA_RSV_01_L2,
        SKILL_RICOTTA_RSV_02_L2,
        SKILL_RICOTTA_RSV_03_L2,
        SKILL_RICOTTA_RSV_04_L2,
        SKILL_RICOTTA_RSV_05_L2,
        SKILL_RICOTTA_RSV_06_L2,
        SKILL_RICOTTA_RSV_07_L2,
        SKILL_RICOTTA_RSV_08_L2,
        SKILL_RICOTTA_SP_C1_L3,
        SKILL_RICOTTA_SP_C2_L3,
        SKILL_RICOTTA_SP_C3_L3,
        SKILL_RICOTTA_SP_C4_L3,
        SKILL_RICOTTA_SP_B1_L3,
        SKILL_RICOTTA_SP_B2_L3,
        SKILL_RICOTTA_SP_B3_L3,
        SKILL_RICOTTA_SP_B4_L3,
        SKILL_RICOTTA_SP_B5_L3,
        SKILL_RICOTTA_SP_A1_L3,
        SKILL_RICOTTA_SP_A2_L3,
        SKILL_RICOTTA_SP_A3_L3,
        SKILL_RICOTTA_RSV_01_L3,
        SKILL_RICOTTA_RSV_02_L3,
        SKILL_RICOTTA_RSV_03_L3,
        SKILL_RICOTTA_RSV_04_L3,
        SKILL_RICOTTA_RSV_05_L3,
        SKILL_RICOTTA_RSV_06_L3,
        SKILL_RICOTTA_RSV_07_L3,
        SKILL_RICOTTA_RSV_08_L3,
        SKILL_RICOTTA_BOM1,
        SKILL_RICOTTA_BOM2,

        SKILL_DANA_SP_C1,
        SKILL_DANA_SP_C2,
        SKILL_DANA_SP_C3,
        SKILL_DANA_SP_C4,
        SKILL_DANA_SP_B1,
        SKILL_DANA_SP_B2,
        SKILL_DANA_SP_B3,
        SKILL_DANA_SP_B4,
        SKILL_DANA_SP_B5,
        SKILL_DANA_SP_A1,
        SKILL_DANA_SP_A2,
        SKILL_DANA_SP_A3,
        SKILL_DANA_RSV_01,
        SKILL_DANA_RSV_02,
        SKILL_DANA_RSV_03,
        SKILL_DANA_RSV_04,
        SKILL_DANA_RSV_05,
        SKILL_DANA_RSV_06,
        SKILL_DANA_RSV_07,
        SKILL_DANA_RSV_08,
        SKILL_DANA_SP_C1_L2,
        SKILL_DANA_SP_C2_L2,
        SKILL_DANA_SP_C3_L2,
        SKILL_DANA_SP_C4_L2,
        SKILL_DANA_SP_B1_L2,
        SKILL_DANA_SP_B2_L2,
        SKILL_DANA_SP_B3_L2,
        SKILL_DANA_SP_B4_L2,
        SKILL_DANA_SP_B5_L2,
        SKILL_DANA_SP_A1_L2,
        SKILL_DANA_SP_A2_L2,
        SKILL_DANA_SP_A3_L2,
        SKILL_DANA_RSV_01_L2,
        SKILL_DANA_RSV_02_L2,
        SKILL_DANA_RSV_03_L2,
        SKILL_DANA_RSV_04_L2,
        SKILL_DANA_RSV_05_L2,
        SKILL_DANA_RSV_06_L2,
        SKILL_DANA_RSV_07_L2,
        SKILL_DANA_RSV_08_L2,
        SKILL_DANA_SP_C1_L3,
        SKILL_DANA_SP_C2_L3,
        SKILL_DANA_SP_C3_L3,
        SKILL_DANA_SP_C4_L3,
        SKILL_DANA_SP_B1_L3,
        SKILL_DANA_SP_B2_L3,
        SKILL_DANA_SP_B3_L3,
        SKILL_DANA_SP_B4_L3,
        SKILL_DANA_SP_B5_L3,
        SKILL_DANA_SP_A1_L3,
        SKILL_DANA_SP_A2_L3,
        SKILL_DANA_SP_A3_L3,
        SKILL_DANA_RSV_01_L3,
        SKILL_DANA_RSV_02_L3,
        SKILL_DANA_RSV_03_L3,
        SKILL_DANA_RSV_04_L3,
        SKILL_DANA_RSV_05_L3,
        SKILL_DANA_RSV_06_L3,
        SKILL_DANA_RSV_07_L3,
        SKILL_DANA_RSV_08_L3,
        SKILL_DANA_BOM1,            
        SKILL_DANA_BOM2,            

        SKILL_GUARD,                

        SKILL_MAX
    }
    public class Ys8Skill
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Constructors/Destructors
        #endregion

        #region Helper Methods
        #endregion
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace CrestronModule_LG_M5500C_PROCESSOR_V1_0
{
    public class CrestronModuleClass_LG_M5500C_PROCESSOR_V1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SEND;
        Crestron.Logos.SplusObjects.DigitalInput SEND_2;
        Crestron.Logos.SplusObjects.DigitalInput AIRIN;
        Crestron.Logos.SplusObjects.DigitalInput CHANNELGO;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DIGITALIN;
        Crestron.Logos.SplusObjects.AnalogInput ADDRESS;
        Crestron.Logos.SplusObjects.AnalogInput CHANNELIN;
        Crestron.Logos.SplusObjects.BufferInput FROMDEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TODEVICE__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput CHANNEL;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> ANALOGOUT;
        ushort SEMAPHORE = 0;
        ushort ELEMENT = 0;
        ushort IDRECEIVED = 0;
        ushort [] STORAGE;
        ushort VALUE = 0;
        ushort PARAMETER = 0;
        CrestronString TEMPSTRING__DOLLAR__;
        private ushort CALCULATE (  SplusExecutionContext __context__, ushort MSB , ushort LSB ) 
            { 
            
            __context__.SourceCodeLine = 57;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( MSB >= 97 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( MSB <= 102 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 58;
                MSB = (ushort) ( (MSB - 87) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 60;
                MSB = (ushort) ( (MSB - 48) ) ; 
                }
            
            __context__.SourceCodeLine = 61;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( LSB >= 97 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( LSB <= 102 ) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 62;
                LSB = (ushort) ( (LSB - 87) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 64;
                LSB = (ushort) ( (LSB - 48) ) ; 
                }
            
            __context__.SourceCodeLine = 65;
            return (ushort)( ((MSB * 16) + LSB)) ; 
            
            }
            
        object DIGITALIN_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 74;
                ELEMENT = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DIGITALIN_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 79;
            ELEMENT = (ushort) ( 0 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SEND_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 84;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT < 7 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT > 0 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 86;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STORAGE[ ELEMENT ] < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 88;
                STORAGE [ ELEMENT] = (ushort) ( (STORAGE[ ELEMENT ] + 1) ) ; 
                __context__.SourceCodeLine = 89;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)ELEMENT);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 91;
                            MakeString ( TODEVICE__DOLLAR__ , "kg {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 92;
                            MakeString ( TODEVICE__DOLLAR__ , "kh {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 93;
                            MakeString ( TODEVICE__DOLLAR__ , "ki {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 94;
                            MakeString ( TODEVICE__DOLLAR__ , "kj {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 95;
                            MakeString ( TODEVICE__DOLLAR__ , "kk {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 96;
                            MakeString ( TODEVICE__DOLLAR__ , "kf {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 100;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT > 6 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT < 13 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 102;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STORAGE[ (ELEMENT - 6) ] > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 104;
                    STORAGE [ (ELEMENT - 6)] = (ushort) ( (STORAGE[ (ELEMENT - 6) ] - 1) ) ; 
                    __context__.SourceCodeLine = 105;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_2__ = ((int)(ELEMENT - 6));
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 107;
                                MakeString ( TODEVICE__DOLLAR__ , "kg {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 108;
                                MakeString ( TODEVICE__DOLLAR__ , "kh {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 109;
                                MakeString ( TODEVICE__DOLLAR__ , "ki {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 110;
                                MakeString ( TODEVICE__DOLLAR__ , "kj {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 111;
                                MakeString ( TODEVICE__DOLLAR__ , "kk {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 112;
                                MakeString ( TODEVICE__DOLLAR__ , "kf {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SEND_2_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 120;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT < 7 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT > 0 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 122;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STORAGE[ ELEMENT ] < 100 ))  ) ) 
                { 
                __context__.SourceCodeLine = 124;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STORAGE[ ELEMENT ] < 89 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 125;
                    STORAGE [ ELEMENT] = (ushort) ( (STORAGE[ ELEMENT ] + 10) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 127;
                    STORAGE [ ELEMENT] = (ushort) ( 100 ) ; 
                    }
                
                __context__.SourceCodeLine = 128;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_3__ = ((int)ELEMENT);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 130;
                            MakeString ( TODEVICE__DOLLAR__ , "kg {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 131;
                            MakeString ( TODEVICE__DOLLAR__ , "kh {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 132;
                            MakeString ( TODEVICE__DOLLAR__ , "ki {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 133;
                            MakeString ( TODEVICE__DOLLAR__ , "kj {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 134;
                            MakeString ( TODEVICE__DOLLAR__ , "kk {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 135;
                            MakeString ( TODEVICE__DOLLAR__ , "kf {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ ELEMENT ]) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                } 
            
            } 
        
        else 
            {
            __context__.SourceCodeLine = 139;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT > 6 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ELEMENT < 13 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 141;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STORAGE[ (ELEMENT - 6) ] > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 143;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STORAGE[ (ELEMENT - 6) ] > 9 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 144;
                        STORAGE [ (ELEMENT - 6)] = (ushort) ( (STORAGE[ (ELEMENT - 6) ] - 10) ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 146;
                        STORAGE [ (ELEMENT - 6)] = (ushort) ( 0 ) ; 
                        }
                    
                    __context__.SourceCodeLine = 147;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_4__ = ((int)(ELEMENT - 6));
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 1) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 149;
                                MakeString ( TODEVICE__DOLLAR__ , "kg {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 2) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 150;
                                MakeString ( TODEVICE__DOLLAR__ , "kh {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 3) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 151;
                                MakeString ( TODEVICE__DOLLAR__ , "ki {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 4) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 152;
                                MakeString ( TODEVICE__DOLLAR__ , "kj {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 5) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 153;
                                MakeString ( TODEVICE__DOLLAR__ , "kk {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 6) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 154;
                                MakeString ( TODEVICE__DOLLAR__ , "kf {0:X2} {1:X2}\r", ADDRESS  .UshortValue, STORAGE[ (ELEMENT - 6) ]) ; 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNELGO_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 162;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AIRIN  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 163;
            MakeString ( TODEVICE__DOLLAR__ , "ma {0:X2} {1:X2} 0 0 00\r", ADDRESS  .UshortValue, CHANNELIN  .UshortValue) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 165;
            MakeString ( TODEVICE__DOLLAR__ , "ma {0:X2} {1:X2} 0 0 01\r", ADDRESS  .UshortValue, CHANNELIN  .UshortValue) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FROMDEVICE__DOLLAR___OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 170;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 172;
            SEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 173;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( Functions.Find( "\u000D" , FROMDEVICE__DOLLAR__ ) > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( Functions.Length( FROMDEVICE__DOLLAR__ ) > 8 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 175;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "NG" , FROMDEVICE__DOLLAR__ ) > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 177;
                    TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROMDEVICE__DOLLAR__ )  ) ; 
                    __context__.SourceCodeLine = 178;
                    TEMPSTRING__DOLLAR__  .UpdateValue ( ""  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 180;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FROMDEVICE__DOLLAR__ ) > 21 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 182;
                        TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROMDEVICE__DOLLAR__ )  ) ; 
                        __context__.SourceCodeLine = 183;
                        IDRECEIVED = (ushort) ( CALCULATE( __context__ , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) ) , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) ) ) ) ; 
                        __context__.SourceCodeLine = 184;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDRECEIVED == ADDRESS  .UshortValue))  ) ) 
                            { 
                            __context__.SourceCodeLine = 186;
                            PARAMETER = (ushort) ( Byte( TEMPSTRING__DOLLAR__ , (int)( 1 ) ) ) ; 
                            __context__.SourceCodeLine = 187;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PARAMETER == 65))  ) ) 
                                { 
                                __context__.SourceCodeLine = 189;
                                CHANNEL  .Value = (ushort) ( CALCULATE( __context__ , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 8 ) ) ) , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 9 ) ) ) ) ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 193;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( FROMDEVICE__DOLLAR__ ) > 10 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 195;
                            TEMPSTRING__DOLLAR__  .UpdateValue ( Functions.Remove ( "\u000D" , FROMDEVICE__DOLLAR__ )  ) ; 
                            __context__.SourceCodeLine = 196;
                            IDRECEIVED = (ushort) ( CALCULATE( __context__ , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 3 ) ) ) , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 4 ) ) ) ) ) ; 
                            __context__.SourceCodeLine = 197;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDRECEIVED == ADDRESS  .UshortValue))  ) ) 
                                { 
                                __context__.SourceCodeLine = 199;
                                PARAMETER = (ushort) ( Byte( TEMPSTRING__DOLLAR__ , (int)( 1 ) ) ) ; 
                                __context__.SourceCodeLine = 200;
                                VALUE = (ushort) ( CALCULATE( __context__ , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 8 ) ) ) , (ushort)( Byte( TEMPSTRING__DOLLAR__ , (int)( 9 ) ) ) ) ) ; 
                                __context__.SourceCodeLine = 201;
                                
                                    {
                                    int __SPLS_TMPVAR__SWTCH_5__ = ((int)PARAMETER);
                                    
                                        { 
                                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 103) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 205;
                                            ANALOGOUT [ 1]  .Value = (ushort) ( VALUE ) ; 
                                            __context__.SourceCodeLine = 206;
                                            STORAGE [ 1] = (ushort) ( VALUE ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 104) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 210;
                                            ANALOGOUT [ 2]  .Value = (ushort) ( VALUE ) ; 
                                            __context__.SourceCodeLine = 211;
                                            STORAGE [ 2] = (ushort) ( VALUE ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 105) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 215;
                                            ANALOGOUT [ 3]  .Value = (ushort) ( VALUE ) ; 
                                            __context__.SourceCodeLine = 216;
                                            STORAGE [ 3] = (ushort) ( VALUE ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 106) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 220;
                                            ANALOGOUT [ 4]  .Value = (ushort) ( VALUE ) ; 
                                            __context__.SourceCodeLine = 221;
                                            STORAGE [ 4] = (ushort) ( VALUE ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 107) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 225;
                                            ANALOGOUT [ 5]  .Value = (ushort) ( VALUE ) ; 
                                            __context__.SourceCodeLine = 226;
                                            STORAGE [ 5] = (ushort) ( VALUE ) ; 
                                            } 
                                        
                                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 102) ) ) ) 
                                            { 
                                            __context__.SourceCodeLine = 230;
                                            ANALOGOUT [ 6]  .Value = (ushort) ( VALUE ) ; 
                                            __context__.SourceCodeLine = 231;
                                            STORAGE [ 6] = (ushort) ( VALUE ) ; 
                                            } 
                                        
                                        } 
                                        
                                    }
                                    
                                
                                } 
                            
                            } 
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 173;
                } 
            
            __context__.SourceCodeLine = 237;
            SEMAPHORE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 247;
        SEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 248;
        ELEMENT = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    STORAGE  = new ushort[ 17 ];
    TEMPSTRING__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    SEND = new Crestron.Logos.SplusObjects.DigitalInput( SEND__DigitalInput__, this );
    m_DigitalInputList.Add( SEND__DigitalInput__, SEND );
    
    SEND_2 = new Crestron.Logos.SplusObjects.DigitalInput( SEND_2__DigitalInput__, this );
    m_DigitalInputList.Add( SEND_2__DigitalInput__, SEND_2 );
    
    AIRIN = new Crestron.Logos.SplusObjects.DigitalInput( AIRIN__DigitalInput__, this );
    m_DigitalInputList.Add( AIRIN__DigitalInput__, AIRIN );
    
    CHANNELGO = new Crestron.Logos.SplusObjects.DigitalInput( CHANNELGO__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNELGO__DigitalInput__, CHANNELGO );
    
    DIGITALIN = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        DIGITALIN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DIGITALIN__DigitalInput__ + i, DIGITALIN__DigitalInput__, this );
        m_DigitalInputList.Add( DIGITALIN__DigitalInput__ + i, DIGITALIN[i+1] );
    }
    
    ADDRESS = new Crestron.Logos.SplusObjects.AnalogInput( ADDRESS__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ADDRESS__AnalogSerialInput__, ADDRESS );
    
    CHANNELIN = new Crestron.Logos.SplusObjects.AnalogInput( CHANNELIN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CHANNELIN__AnalogSerialInput__, CHANNELIN );
    
    CHANNEL = new Crestron.Logos.SplusObjects.AnalogOutput( CHANNEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHANNEL__AnalogSerialOutput__, CHANNEL );
    
    ANALOGOUT = new InOutArray<AnalogOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        ANALOGOUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( ANALOGOUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( ANALOGOUT__AnalogSerialOutput__ + i, ANALOGOUT[i+1] );
    }
    
    TODEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TODEVICE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TODEVICE__DOLLAR____AnalogSerialOutput__, TODEVICE__DOLLAR__ );
    
    FROMDEVICE__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( FROMDEVICE__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( FROMDEVICE__DOLLAR____AnalogSerialInput__, FROMDEVICE__DOLLAR__ );
    
    
    for( uint i = 0; i < 12; i++ )
        DIGITALIN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( DIGITALIN_OnPush_0, false ) );
        
    for( uint i = 0; i < 12; i++ )
        DIGITALIN[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( DIGITALIN_OnRelease_1, false ) );
        
    SEND.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_OnPush_2, false ) );
    SEND_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SEND_2_OnPush_3, false ) );
    CHANNELGO.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNELGO_OnPush_4, false ) );
    FROMDEVICE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FROMDEVICE__DOLLAR___OnChange_5, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_LG_M5500C_PROCESSOR_V1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SEND__DigitalInput__ = 0;
const uint SEND_2__DigitalInput__ = 1;
const uint AIRIN__DigitalInput__ = 2;
const uint CHANNELGO__DigitalInput__ = 3;
const uint DIGITALIN__DigitalInput__ = 4;
const uint ADDRESS__AnalogSerialInput__ = 0;
const uint CHANNELIN__AnalogSerialInput__ = 1;
const uint FROMDEVICE__DOLLAR____AnalogSerialInput__ = 2;
const uint TODEVICE__DOLLAR____AnalogSerialOutput__ = 0;
const uint CHANNEL__AnalogSerialOutput__ = 1;
const uint ANALOGOUT__AnalogSerialOutput__ = 2;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}

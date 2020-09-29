using System;
using System.ComponentModel;
using System.Diagnostics;

namespace CelestialTools.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public CLSForm m_CLSForm;

            public CLSForm CLSForm
            {
                [DebuggerHidden]
                get
                {
                    m_CLSForm = Create__Instance__(m_CLSForm);
                    return m_CLSForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CLSForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CLSForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CSVUpdater m_CSVUpdater;

            public CSVUpdater CSVUpdater
            {
                [DebuggerHidden]
                get
                {
                    m_CSVUpdater = Create__Instance__(m_CSVUpdater);
                    return m_CSVUpdater;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CSVUpdater))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CSVUpdater);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CSVUpdaterInfo m_CSVUpdaterInfo;

            public CSVUpdaterInfo CSVUpdaterInfo
            {
                [DebuggerHidden]
                get
                {
                    m_CSVUpdaterInfo = Create__Instance__(m_CSVUpdaterInfo);
                    return m_CSVUpdaterInfo;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CSVUpdaterInfo))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CSVUpdaterInfo);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public CustomPlot m_CustomPlot;

            public CustomPlot CustomPlot
            {
                [DebuggerHidden]
                get
                {
                    m_CustomPlot = Create__Instance__(m_CustomPlot);
                    return m_CustomPlot;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_CustomPlot))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_CustomPlot);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DeckLogHelp m_DeckLogHelp;

            public DeckLogHelp DeckLogHelp
            {
                [DebuggerHidden]
                get
                {
                    m_DeckLogHelp = Create__Instance__(m_DeckLogHelp);
                    return m_DeckLogHelp;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DeckLogHelp))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DeckLogHelp);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DeckLogUpdate m_DeckLogUpdate;

            public DeckLogUpdate DeckLogUpdate
            {
                [DebuggerHidden]
                get
                {
                    m_DeckLogUpdate = Create__Instance__(m_DeckLogUpdate);
                    return m_DeckLogUpdate;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DeckLogUpdate))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DeckLogUpdate);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DevForm m_DevForm;

            public DevForm DevForm
            {
                [DebuggerHidden]
                get
                {
                    m_DevForm = Create__Instance__(m_DevForm);
                    return m_DevForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DevForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DevForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DisplayEQTData m_DisplayEQTData;

            public DisplayEQTData DisplayEQTData
            {
                [DebuggerHidden]
                get
                {
                    m_DisplayEQTData = Create__Instance__(m_DisplayEQTData);
                    return m_DisplayEQTData;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DisplayEQTData))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DisplayEQTData);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public DisplayMTData m_DisplayMTData;

            public DisplayMTData DisplayMTData
            {
                [DebuggerHidden]
                get
                {
                    m_DisplayMTData = Create__Instance__(m_DisplayMTData);
                    return m_DisplayMTData;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_DisplayMTData))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_DisplayMTData);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FavoriteLocations m_FavoriteLocations;

            public FavoriteLocations FavoriteLocations
            {
                [DebuggerHidden]
                get
                {
                    m_FavoriteLocations = Create__Instance__(m_FavoriteLocations);
                    return m_FavoriteLocations;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FavoriteLocations))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FavoriteLocations);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FixDG m_FixDG;

            public FixDG FixDG
            {
                [DebuggerHidden]
                get
                {
                    m_FixDG = Create__Instance__(m_FixDG);
                    return m_FixDG;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FixDG))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FixDG);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form60DST m_Form60DST;

            public Form60DST Form60DST
            {
                [DebuggerHidden]
                get
                {
                    m_Form60DST = Create__Instance__(m_Form60DST);
                    return m_Form60DST;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form60DST))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form60DST);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form7 m_Form7;

            public Form7 Form7
            {
                [DebuggerHidden]
                get
                {
                    m_Form7 = Create__Instance__(m_Form7);
                    return m_Form7;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form7))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form7);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormAltSR m_FormAltSR;

            public FormAltSR FormAltSR
            {
                [DebuggerHidden]
                get
                {
                    m_FormAltSR = Create__Instance__(m_FormAltSR);
                    return m_FormAltSR;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormAltSR))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormAltSR);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormArcTime m_FormArcTime;

            public FormArcTime FormArcTime
            {
                [DebuggerHidden]
                get
                {
                    m_FormArcTime = Create__Instance__(m_FormArcTime);
                    return m_FormArcTime;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormArcTime))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormArcTime);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormCTSSOA m_FormCTSSOA;

            public FormCTSSOA FormCTSSOA
            {
                [DebuggerHidden]
                get
                {
                    m_FormCTSSOA = Create__Instance__(m_FormCTSSOA);
                    return m_FormCTSSOA;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormCTSSOA))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormCTSSOA);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormCurrents m_FormCurrents;

            public FormCurrents FormCurrents
            {
                [DebuggerHidden]
                get
                {
                    m_FormCurrents = Create__Instance__(m_FormCurrents);
                    return m_FormCurrents;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormCurrents))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormCurrents);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormDevTable_frm m_FormDevTable_frm;

            public FormDevTable_frm FormDevTable_frm
            {
                [DebuggerHidden]
                get
                {
                    m_FormDevTable_frm = Create__Instance__(m_FormDevTable_frm);
                    return m_FormDevTable_frm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormDevTable_frm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormDevTable_frm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormDistances m_FormDistances;

            public FormDistances FormDistances
            {
                [DebuggerHidden]
                get
                {
                    m_FormDistances = Create__Instance__(m_FormDistances);
                    return m_FormDistances;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormDistances))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormDistances);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormIandC m_FormIandC;

            public FormIandC FormIandC
            {
                [DebuggerHidden]
                get
                {
                    m_FormIandC = Create__Instance__(m_FormIandC);
                    return m_FormIandC;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormIandC))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormIandC);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormLength m_FormLength;

            public FormLength FormLength
            {
                [DebuggerHidden]
                get
                {
                    m_FormLength = Create__Instance__(m_FormLength);
                    return m_FormLength;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormLength))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormLength);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormMeridianDiagram m_FormMeridianDiagram;

            public FormMeridianDiagram FormMeridianDiagram
            {
                [DebuggerHidden]
                get
                {
                    m_FormMeridianDiagram = Create__Instance__(m_FormMeridianDiagram);
                    return m_FormMeridianDiagram;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormMeridianDiagram))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormMeridianDiagram);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormMoBoard m_FormMoBoard;

            public FormMoBoard FormMoBoard
            {
                [DebuggerHidden]
                get
                {
                    m_FormMoBoard = Create__Instance__(m_FormMoBoard);
                    return m_FormMoBoard;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormMoBoard))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormMoBoard);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormNavMath m_FormNavMath;

            public FormNavMath FormNavMath
            {
                [DebuggerHidden]
                get
                {
                    m_FormNavMath = Create__Instance__(m_FormNavMath);
                    return m_FormNavMath;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormNavMath))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormNavMath);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormNoonSight m_FormNoonSight;

            public FormNoonSight FormNoonSight
            {
                [DebuggerHidden]
                get
                {
                    m_FormNoonSight = Create__Instance__(m_FormNoonSight);
                    return m_FormNoonSight;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormNoonSight))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormNoonSight);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormSailings m_FormSailings;

            public FormSailings FormSailings
            {
                [DebuggerHidden]
                get
                {
                    m_FormSailings = Create__Instance__(m_FormSailings);
                    return m_FormSailings;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormSailings))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormSailings);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormSightPlan m_FormSightPlan;

            public FormSightPlan FormSightPlan
            {
                [DebuggerHidden]
                get
                {
                    m_FormSightPlan = Create__Instance__(m_FormSightPlan);
                    return m_FormSightPlan;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormSightPlan))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormSightPlan);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormSRF m_FormSRF;

            public FormSRF FormSRF
            {
                [DebuggerHidden]
                get
                {
                    m_FormSRF = Create__Instance__(m_FormSRF);
                    return m_FormSRF;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormSRF))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormSRF);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormTides m_FormTides;

            public FormTides FormTides
            {
                [DebuggerHidden]
                get
                {
                    m_FormTides = Create__Instance__(m_FormTides);
                    return m_FormTides;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormTides))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormTides);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormTVMDC m_FormTVMDC;

            public FormTVMDC FormTVMDC
            {
                [DebuggerHidden]
                get
                {
                    m_FormTVMDC = Create__Instance__(m_FormTVMDC);
                    return m_FormTVMDC;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormTVMDC))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormTVMDC);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormTwoBearings m_FormTwoBearings;

            public FormTwoBearings FormTwoBearings
            {
                [DebuggerHidden]
                get
                {
                    m_FormTwoBearings = Create__Instance__(m_FormTwoBearings);
                    return m_FormTwoBearings;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormTwoBearings))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormTwoBearings);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormVertical m_FormVertical;

            public FormVertical FormVertical
            {
                [DebuggerHidden]
                get
                {
                    m_FormVertical = Create__Instance__(m_FormVertical);
                    return m_FormVertical;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormVertical))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormVertical);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmAbout m_frmAbout;

            public frmAbout frmAbout
            {
                [DebuggerHidden]
                get
                {
                    m_frmAbout = Create__Instance__(m_frmAbout);
                    return m_frmAbout;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmAbout))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmAbout);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmCredits m_frmCredits;

            public frmCredits frmCredits
            {
                [DebuggerHidden]
                get
                {
                    m_frmCredits = Create__Instance__(m_frmCredits);
                    return m_frmCredits;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmCredits))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmCredits);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPointsOnGCR m_frmPointsOnGCR;

            public frmPointsOnGCR frmPointsOnGCR
            {
                [DebuggerHidden]
                get
                {
                    m_frmPointsOnGCR = Create__Instance__(m_frmPointsOnGCR);
                    return m_frmPointsOnGCR;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmPointsOnGCR))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmPointsOnGCR);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmPointsOnRhumb m_frmPointsOnRhumb;

            public frmPointsOnRhumb frmPointsOnRhumb
            {
                [DebuggerHidden]
                get
                {
                    m_frmPointsOnRhumb = Create__Instance__(m_frmPointsOnRhumb);
                    return m_frmPointsOnRhumb;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmPointsOnRhumb))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmPointsOnRhumb);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public HelpV2 m_HelpV2;

            public HelpV2 HelpV2
            {
                [DebuggerHidden]
                get
                {
                    m_HelpV2 = Create__Instance__(m_HelpV2);
                    return m_HelpV2;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_HelpV2))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_HelpV2);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MainMenu m_MainMenu;

            public MainMenu MainMenu
            {
                [DebuggerHidden]
                get
                {
                    m_MainMenu = Create__Instance__(m_MainMenu);
                    return m_MainMenu;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MainMenu))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MainMenu);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SightLog m_SightLog;

            public SightLog SightLog
            {
                [DebuggerHidden]
                get
                {
                    m_SightLog = Create__Instance__(m_SightLog);
                    return m_SightLog;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SightLog))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SightLog);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public SRFTimeDiagram m_SRFTimeDiagram;

            public SRFTimeDiagram SRFTimeDiagram
            {
                [DebuggerHidden]
                get
                {
                    m_SRFTimeDiagram = Create__Instance__(m_SRFTimeDiagram);
                    return m_SRFTimeDiagram;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SRFTimeDiagram))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SRFTimeDiagram);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TestDev m_TestDev;

            public TestDev TestDev
            {
                [DebuggerHidden]
                get
                {
                    m_TestDev = Create__Instance__(m_TestDev);
                    return m_TestDev;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TestDev))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TestDev);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TraverseTable m_TraverseTable;

            public TraverseTable TraverseTable
            {
                [DebuggerHidden]
                get
                {
                    m_TraverseTable = Create__Instance__(m_TraverseTable);
                    return m_TraverseTable;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TraverseTable))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TraverseTable);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ZTInfo m_ZTInfo;

            public ZTInfo ZTInfo
            {
                [DebuggerHidden]
                get
                {
                    m_ZTInfo = Create__Instance__(m_ZTInfo);
                    return m_ZTInfo;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_ZTInfo))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ZTInfo);
                }
            }
        }
    }
}
(function (root, factory) {if (typeof define === 'function' && define.amd) {define(['exports', 'echarts'], factory);} else if (typeof exports === 'object' && typeof exports.nodeName !== 'string') {factory(exports, require('echarts'));} else {factory({}, root.echarts);}}(this, function (exports, echarts) {var log = function (msg) {if (typeof console !== 'undefined') {console && console.error && console.error(msg);}};if (!echarts) {log('ECharts is not Loaded');return;}if (!echarts.registerMap) {log('ECharts Map is not loaded');return;}echarts.registerMap('fuzhou', {"type":"FeatureCollection","features":[{"type":"Feature","id":"350111","properties":{"name":"晋安区","cp":[119.328597,26.078837],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@@@@@@A@AA@@AA@A@@AA@@@A@A@AAC@@@A@@@@@B@@@B@DABBF@FAD@DE@@BCAAA@AA@@@CBIAICICA@AEGAEBC@@FCHADC@@@A@ABA@ABA@@@@A@A@A@C@A@A@C@CAAAAA@@EECAA@CD@@@@@@ABA@BEDCDIBABBDDBHBB@@@@@B@@BBBBB@BBB@BBB@B@B@B@B@D@@ABBB@@BDADCBEBCDCBAFBHDFFBD@DADADBDDFFBDABCFCBADBDAFCDC@AAA@ABA@C@@@CAA@C@CBC@CBA@C@ABA@A@C@ABAB@@ABAB@BA@@BBB@@@DAB@DADCBGAEGGGEEE@ABCBC@CCEEGAEBCHEJADAACAEAC@@FEFC@AACAC@CDCHC@C@C@CBEFEDCB@@@FCD@FBFBHAJGB@BC@C@CFAFADG@CAECE@GBCDCBA@CACCEACAAB@DBFBHBBCBC@ADAFIDC@A@CBAF@R@PBNCDCDGBABABADADA@@DA@@BA@C@A@@@ACGCCB@DC@G@@OCCA@CDCFE@MKG@KHGAEGBI@MI@GJGHIAMEKMIKDCEAQ@C@A@@@@AC@@@A@@@@@@@@A@@@A@@AA@@@CC@@@@AAEC@@@@@@AA@@@AAA@ABA@A@AB@DADCAA@A@@@@@A@AAABAA@@C@@EC@@@A@ABA@A@@@AA@@@B@@A@@A@C@B@ABA@A@@@@AC@@@A@@B@@@BA@@BA@QGIGAACCA@EBGJCFAFAHAFADCBEBEBC@A@GBE@IBA@GAI@GBE@@@@BAF@D@F@D@DAB@B@B@DA@@BADADAB@@AB@DAH@D@FAB@BCFCNCHADAB@@EHCDSDUAIDEBMG@@@@KG@DCFGFKFKDEFAH@L@FDHJDFHDL@HCJEFIDGLKBIAGBGDAHDFAHILEH@JFHJJDX@LCHIFEBCD@DABGBI@KBGJGLAH@DDFJDH@H@BDAH@@CB@D@@EHMJMHEDDFFDDH@FGJCHAFBFLBTFHF@HAJG\\@LDHHHJBP@TBLHFJALAL@HFHJBDBF@DGDAF@HFFHBBHHDDD@B@DADAB@@BDAB@BABA@A@AB@@@B@B@B@BB@BD@BDBDDF@B@B@B@@BBB@B@@@@A@A@AAA@@@A@@@@@A@A@A"],"encodeOffsets":[[122151,27038]]}},{"type":"Feature","id":"350103","properties":{"name":"台江区","cp":[119.310156,26.058616],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@@E@CBE@A@@F@HAJ@HBB@JAF@HAB@D@FAFADABCBEBGBEDECMcXWFWDQAKGEAI@I@ID]NMHBDBBB@@@@@@@@B@@@@@@B@@@@@DBB@@@BBBBB@AB@@DBD@BBDB@@@@@@D@B@@@BB@B@B@@@@@@@@@@@@@@B@@@@@D@D@B@B@B@D@B@B@B@@@BBD@@@D@D@@@@@FB@A@A@@@@@@@@@AB@@@BAB@@@B@@@B@@@B@@@F@"],"encodeOffsets":[[122187,26696]]}},{"type":"Feature","id":"350105","properties":{"name":"马尾区","cp":[119.458725,25.991975],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@@IBEDEBCHCFAPARM@ECEFUDCD@LBB@@AB@@S@CBCDCBEBEBCDaBM»LQBUAOB@@@@MBKFEFGTGJIDMBKCMIKMMOEGCG@MCQOUIOOW@C@A@@AAAACEAACCCCACIEECEAECCAQKMGGbAJADQNeXGBSDSHURWVA@DNHIFAB@DDBBJHRHB@@AB@@A@@@AB@@@D@@B@@B@B@BAA@D@B@@@@BA@@@B@@B@@@BAB@B@B@@FD@@@DB@ABBB@B@B@@@@@BBBCDCBA@@B@BAB@BBB@B@@BB@@@@@@FDBB@@@@DD@@B@@BB@@@B@@@@@@@@@@B@@BD@@@@@B@DBRDFLCNJFLBNGJIH@HNJJ@HABFGH@LLH@NEFCD@DDBPDDALCJAH@DADCHAD@DCBEDCD@FBDBF@F@@@B@HFH@HCJGJCHCHGFADEFGFEH@F@BAF@HADCHC@@PJ|LtH"],"encodeOffsets":[[122486,26760]]}},{"type":"Feature","id":"350104","properties":{"name":"仓山区","cp":[119.320988,26.038912],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@NG^MJCJ@J@FBLHRBXCXEdWB@XUVQTGTCHAfWRMBCBIHaKESEMA]@SC@BA@E@K@GBEHAFKJMFGBO@U@A@CBC@E@C@G@EBGBE@GBE@GBE@E@CAC@GCC@@@AAC@CBCDEBC@ADMHOL@BADCDC@ONQLGHIRCDGNITEP@RBX@XCXCJ@BBBBBDBBBB@DBDBB@DB@@D@DCBCBCBABA@@JUL[d]"],"encodeOffsets":[[122135,26684]]}},{"type":"Feature","id":"350121","properties":{"name":"闽侯县","cp":[119.145117,26.148567],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@ASCICECCACAG@EBG@CAEAACCCCFCDEDEDERIREVAJELKPGBA@EAEACECGCGCECAGDAHCJEHCHCDABCFCJCJALAF@CE@GHEJCJAHCDEBC@A@ABADCHA@@B@DCFCDGCAIAEG@GBKBKEIKGSAO@IAGGCG@KH[BI@GGESEKAAEBEDGHI@ECGECCEFCNGNIFG@@@CDA@@BGACG@G@ICCE@CBGHKHILAJ@HABA@CDCFAJEDG@KCWIIEG@IFGJKBGCEBGHCHAJBLAHKJCFEDI@GCKEGICCG@E@KBGFELCLEHEDE@C@C@K@GEG@AA@CACA@@CACACAA@ABCB@@@@ABABADADCDC@@@CAA@CACAA@AACAAAAA@ADIDW@WAW@QFOJSHMDCJQHGRKPMD@DCBC@APKNGBCD@FADCDAD@BB@@D@HDD@DBF@F@HAF@HAF@HAFAH@D@F@D@DAB@V@P@HANELIBEFGHAL@F@B@@ATDBAGIAA@CAE@ACE@@FMDKBIBIDCD@B@D@B@DBB@@ABA@G@C@E@C@CBCBEBABE@CAA@ACAA@BEFC@EQE@A@CBC@CBAFGBEACEIEKGMKEAC@IFCDC@G@KEECEACAECMACECAEACAC@AACA@@AA@C@E@C@C@A@A@E@A@AB@@@B@DABAB@B@B@B@BADAB@@@BE@EDGBEAGGEEG@EDEFIHEDA@C@C@EBCBAF@DAFCFCDCD@D@DAHCBCAECCCACAACCECC@CA@@C@GDCF@F@HCHCH@H@DA@@@A@GAICKGAAABA@A@@@AA@@@@AA@@@A@@AAAAAAA@AB@@CBABA@C@AAA@@@A@C@AAABAB@@A@A@AAAA@A@A@A@A@@@AAOAE@ACBCFILIFA@CDABAB@@AA@@CDCFCFADGBIFCFCJ@N@BFFDL@BAHADEBEAI@KFGH@F@H@@G@C@CAC@CAAAEAAACD@@ADAFCDCBC@C@CAECEGCCEACAEAC@CB@@CBCAAAA@@@AB@BDFJDDFADCDE@E@A@CDEHCLAFABCBC@ABAHBHDJDJBLDJDFLDDBADCD@BCBGBECIEICE@CD@HBFBB@@BBDFBFFHFH@F@DIDGDADADABC@A@CBC@ABAD@BCFEBKBGBI@KA@@@@IFGHKDKBGCA@CBADEDC@E@EBC@IBECCECB@@CFCDAF@F@DADABG@KEWEM@IDCD@D@DADG@KCGDIHKFGBCFAFBFDF@B@DBFBF@DAFADGBEACAECE@EBEBG@CAECECGAECKEE@GACCG@GFGDEDAHLAFBHDBDFHDJBFAHGF@FBDBFADAHBFBHBHDHBFBFAD@FDDDDFFDDBFAFCDCD@DDDBHBFDHFFFFDFBHDFFBHDFDHH@D@JBL@J@LAD@JBBDDBF@DAH@FBFDBFFFDFFDHHFDDFDFDDBBFBF@FAHADIDC@EAGCECACAGCAEEEGCCCAGCM@IBKDEBAC@IBGECKAMBODCBABAF@H@N@JANAR@H@FFDFD@@H@JDHHFPFNDNHJ@BABAFAHBHBBBBDFBJAJ@HJFRJJHJJDPBNEJ@DJBPB@@JDFFBF@DCDCD@BBBFJBBBBB@D@@@@BB@@@@@B@@AB@@B@@BBBB@BB@B@BA@@@A@@BAB@@A@@BB@@B@BDBFDBDBBBBFFDHBDDD@F@LD@J@D@@BBFJ@@BB@BDDBBBBBD@@BBBTDVHLHNBPENIJCBIHCAEAGA@DAD@FAFCFDBHDFBFDDDDDF@BCBEFG@@B@@@BB@@@B@@ABB@@@@@BBB@B@@@@B@@ABBB@B@BA@@@@B@B@B@@GF@DBD@BGBGBGBCB@B@BADEFEFA@@DDDFDD@HED@DBDD@BAFADBDBDHD@B@DA@C@AD@B@FD@DBBD@D@HBBBBD@FCDAB@B@@DANHDL@RCB@J@DBDDFFDDD@DADEHEFCFEFE@EACIAKGEGAEDCJCHCL@JDF@B@@ADADAD@FBBB@F@FDBB@B@B@@AA@@@@A@A@A@@@@BA@@B@@A@@AA@@@A@@@ABA@@@ABABA@@@AAA@@A@@A@@@@@@@@@@B@B@BA@@B@B@BCBA@@BA@A@@B@@AB@BA@A@@AA@A@A@A@@@A@@BABAB@@@@AB@@A@@AA@@@@@AB@@AB@@@B@BBB@B@B@@AB@B@BB@@@@@B@@@B@@@BD@B@D@D@H@B@@@"],"encodeOffsets":[[121996,27180]]}},{"type":"Feature","id":"350102","properties":{"name":"鼓楼区","cp":[119.29929,26.082284],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@LH@@@@NHFAJCVBTCDCFG@@BABCDGDMDE@ABA@E@CBG@CBA@@BABCBC@AB@@C@A@ABA@C@CE@@@A@@@A@@@A@@@A@AB@@A@@B@@@@@@@@@B@BEA@@@@C@C@@@C@AA@@A@A@A@C@A@A@A@C@C@@@@@A@@@@@@@@@@@@@@@@A@AAA@@A@C@@@@@@@CAAAC@CA@@BAA@AAAA@@A@CA@@@@A@@@@@@@@A@@@@@@A@AAACc^K\\IV@@DABAB@DBDBDB@@DBDBB@@BFH@H@L@D"],"encodeOffsets":[[122124,26744]]}},{"type":"Feature","id":"350123","properties":{"name":"罗源县","cp":[119.552645,26.487234],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@D@DAF@FCD@H@BADAH@FBDB@BAFC@EDGBGDABBBDBBAB@BB@DDBH@DADCFEDEFANBVDHDFBJ@@@B@B@F@BAB@B@B@BA@@BA@BBA@@B@B@D@BB@B@@@B@@B@B@@BB@B@JGHCHADA@EN@FBD@DCBCDCDCAC@IFEHKFADABIFCFABA@AFEDG@AEEEC@@FIDEFEDCF@H@FAFCFAHADABC@EECDCDAJDFAHEFEJBH@BCFC@@F@DDDBF@HAFCFCDC@EFA@CB@FAH@BAAA@C@ADAF@HBJDDDHDB@B@BABBF@F@DCFAJ@FB@B@BBB@B@B@BDF@BF@FC@AB@FDFB@DBFBFBJDJBFBFBDDDFBF@D@FDDDDBDAF@FAFAH@FAHCHCHCJD@@NJFFDBCDCB@DDBHAD@B@D@HBFBH@JAJEJGJC@ABABCFCFCDADA@CBCBAHKfd¥BIBGAICEyYKYIYEgAaAY@QDEHKfGZERCLYZIFGBGCKKMS@@@@@@ACAGAG@EBE@EAGACBE@GEEEAE@GACAE@EBE@EAEAGC@ECGACCCECAAMIIEGAC@CHED@DCDEBGCEEEIGAEAIFAHADBDDDBHBFHBDF@DAB@@E@E@@BEDADAD@@CDEBECIEGAIBAB@F@DDDFFFF@DA@AB@AC@@BA@IEGEEEICICE@AFAFADABG@CAEAIAIAI@GIAC@CAAEEGACBG@ACECGCGEECI@CDCDIBEDECC@GBECEECBAD@F@HAFEHE@EAIDDDDB@BBBBB@@@DAFBD@FAF@HABCBEACABE@ECAE@G@GAGAE@GACEECKEEA@@A@A@CAAAA@CA@@E@G@ADGFAD@BIAEAA@ABABA@C@CB@@G@G@ICECCCA@AEACCACACA@CBCBIAA@@C@A@ABA@CBA@A@@@@@@B@B@B@B@D@B@DBB@BBBBBB@@@@@D@B@@@B@@@B@@@B@B@@@@B@@B@@BBD@@@@@@@@@BB@@@@B@@AD@BA@@AB@@@@A@@@@@@@A@@@A@AA@AC@@@@AA@@@@@@AA@@A@@@@@CBA@A@AAA@@@AA@@AA@@@A@@@A@@AA@A@A@@@A@A@A@@@A@@@@@A@@A@@@@A@@@@@A@B@B@B@@@@@B@@BB@B@B@B@@A@A@AA@@@A@A@ACEACACC@@AAAA@A@A@@@A@@B@BABABA@CB@AA@CBCBA@C@CCGGAAEGGEE@CBCHE@CHEDCDA@@@GBCDAB@B@BADCFGDIBIDGF@HDFE@KBIBIDEDADCBGDGDIFGDCBBHFDHDHDFDBDBF@FABOHKLIFUBQFQJCFCFCFEDDDDDBBBF@DAH@FBHBDDDDFDJBTBAB@BCB@BA@AB@B@@B@B@B@BBB@@DBD@D@B@@@BABAB@@@B@BBB@B@@@B@@AB@D@BFJJD@H@FDHBDDFHDFDBDBDFBDDBFAHCDEBCFGBGDEDCDC@E@E@GDCDEFGDEFAD@FDBARFJJHPBJDFHAVIJGBCFCD@DDBPD^BP@HDHDJFHFFFFDDFBF@H@F@FAB@BA@AA@@A@AD@BABA@A@A@A@@AA@@@A@@A@@@A@A@@A@AA@@@AA@A@@@AB@@@B@B@@BDB@@@A@A@@@@BAB@B@@A@@BB@@@B@BB@BBB@@BB@@AB@@A@@@@B@B@DBBBBDBBBB@B@B@@@BB@B@BB@BB@@@BBBA@@B@D@B@@BBBB@BB@@@B@@AB@BABABA@A@BB@@BBA@@B@@@BB@@@@@B@B@B@B@BCB@@@@B@B@D@DDA@@B@F@@@B@@A@@B@@@AAB@@@@@B@@A@@B@D@JDH@FFFHDH@F@H@BBDB@D@D@BBD@"],"encodeOffsets":[[122254,27262]]}},{"type":"Feature","id":"350122","properties":{"name":"连江县","cp":[119.538365,26.202109],"childNum":45},"geometry":{"type":"MultiPolygon","coordinates":[["@@BGBCFEFEDEFGLQJKBEBE@GBGBCDEHCFEJGDCDEBAACGGAC@A@CBALCJAH@F@L@NDNDZLPFNFJDJ@F@L@FA@CCKKYCEMIWUaUGE@E@CAEEECAG@IAQB[BC@EAGCG@A@AF@FAFCDGFIBIBG@OIuSECAC@C@ABCBAJCJAD@DC@EAIEIKKGGECAAG@CBGFEFEHIHIFI@QGkMaIYCOAI@mGECECACAEBEDGJKDCDABE@EAGIEICACAC@E@E@IAICCAAkKCAEECESSA@WIGCGCAAAA@AAK@I@CBCDEDCDCB@BA@ABIDMsG{KOI@@GDCDGBE@ABE@G@EFEHCFEBGHGDIDIHGDG@GEA@@@E@E@CAEAC@CDAFCDC@GBCDCBG@IBKDCB@@@HCDA@DDDH@B@@@B@DAB@@CB@@CBCBABABABCHCDMDOAQ@E@AB@D@BCDEJCB@BADADGAEACAA@BBBDDFBD@DABCDAD@HDFBF@DCHEBEB@D@DADA@IHGBEAEAC@ED@@A@CDEFAF@D@D@DGDCD@DBDBD@BEDEF@@BDBFBDCBIBGFADBFFHDF@DADAD@BFFHFHHBFAHCDCBA@CB@@A@AA@@ABA@AB@BA@AB@B@D@BAB@B@DAB@DAD@D@DBB@D@@@DAB@BBB@BCDEDCBCAABEDADCBEACEACBCBC@CACEEGCEAABCDADAFCDCB@AA@AA@BC@A@A@A@A@A@AAA@AAA@AAAA@@@A@@@@AAAGCCAAABCJCDAFB@BA@@@@@@DCB@DBFF@@BBBBDBD@B@B@D@B@B@B@@@@@AB@BAB@B@B@@CDGBED@@ADBFFH@BDBDJBJAJ@D@@BBB@BBAD@@CFC@EBE@AACBA@@@A@@@@@B@@@D@BBB@B@@@B@@BB@B@@BB@@B@B@@@@@B@@@@@B@@B@@@@B@@@@@B@@@B@B@B@@@B@BBB@@@B@@@B@@BB@@BB@@B@BBB@B@DA@@@@B@@@BB@@@@@@BB@@@@BDB@@B@B@@@B@@@@@@@B@@A@@BB@@ABC@@@A@@A@@A@@@@@@@@AC@AA@@@@A@@A@A@@@A@@@A@@@A@C@@@@@A@AAAA@AAA@C@A@C@A@A@A@A@@@@B@B@DAB@BAB@D@@@BBAJAD@DDBDBDBBDBFB@DDFDJDH@H@@@DAD@B@BABAB@FBJB@ABCHEBCH@F@@@DBB@BBDBB@B@@@FBLFFDDFHBF@HBHBH@F@DB@FAFDBFBDABA@GBE@EACBE@C@@AAAA@ACACCJCFBF@FGBE@G@EBCDAFFFDHAD@FDFCJADCDCJ@FDHFHDFDBDH@DAHBFFBB@DBDHJJ@JBJBFBDBH@BABCBEBEF@JDJDFFHFJFB@@AD@@BBAB@@CEEEECC@C@EBAJAHBJFFDFADC@@BCBCFC@AF@F@@@BA@CCEGAAEAGCCACBCBGJEFBHBFJFFHDFADC@CFCDGD@HBJFNJBBFDDDBDDH@FHDFBFBF@FAF@DBHBF@FBFF@HAFBDBH@FAF@FBHBHBD@@@@@@NTLLHDHAJEZYDKFQHYLeFGRCZ@bBhBZFZJZLz"],["@@CBABCD@D@BBBDBBBB@@BABAB@BBBFDB@@BDBB@B@BCDI@A@A@ACA@A@A@@BAAAACCAE@CA"],["@@@@AC@@A@AB@@@@@DB@@@D@@A"],["@@@@BCA@@@C@@@@@@D@@@@D@@@"],["@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@A@@@@@@@@A@@@@@@@@@@@@B"],["@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"],["@@AAE@EACACACAG@G@EACACCAE@C@CAC@ABA@A@A@C@@AAIAA@A@AB@N@F@DDJBB@DCNBB@@B@DBD@FDDDD@D@DBB@JJDBFHBDD@F@D@@ABABA@@D@B@BAB@@AACBA@ABAB@D@F@B@BA@A@ECCA@AAAA@A@@BA@A@@@A@AB@BAB@BA@AAAC@C@ABABGLABA@AAAA"],["@@@@@@@@@@@@@@@A@@@@@@@@A@@@@@@@@B@@B@"],["@@ABBBAFEBKBE@EDE@KBABADAFCDKHCDADBFBL@H@DDB@@D@B@DDF@F@PBDCHCBEDGH@@CFGD@LBHAFCB@DBD@D@B@@A@CCAEBC@CAAE@CB@@A@CA@C@A@@ABA@@@C@ADA@AAC@EA@C@MEC@"],["@@A@CDC@ODGD@FBFHJBHC@@B@DFD@HAD@HBFB@F@DADCB@F@DA@A@ACAAEAC@AFAD@BA@AH@BABCD@FDBHDDDDJDT@JC@AACAABACC@CECGKC@ABCBACAACCCCCCEAC@CBCBCACC@A@AEAEA"],["@@@B@@B@@A@@B@@@@A@A@@A@@@A@@@A@@@@B@@@B@@B@"],["@@B@B@@@D@B@@@BA@@@@@A@@@AA@@@A@C@A@A@@@AB@@@@@B@@BB@@"],["@@A@A@@B@@BB@@@@BB@@@@B@B@@@BBA@@@@B@B@@B@@B@@@B@B@@A@@@@B@@@@@@@B@@@@@B@@B@@@@@BA@@@@@A@@@@B@@@B@@@@@B@@@@A@@@A@@BA@AB@B@@AAAA@AAA@AAC@CAA@@A"],["@@DBBB@@@@@@@A@@@@@@@@@@@A@@@A@A@@AA@@@@@@@A@@@@@@@@A@@@@@A@@A@@A@@B@@B@@B@@@BB@@@@@A@@B@@@@@@@@@@@B"],["@@@BBBDBD@B@@@BAA@AAAA@A@A@ABA@ACAA@@A@@B@B@@AAA@ACACAA@A@@AAAC@@B@@@B@@@@A@C@@B@BBBB@B@BB@BBDDBBDBD"],["@@@@B@@AA@@@A@@@@@@@@BB@@@"],["@@@@@BB@@BB@@BB@@BB@@A@@@@@C@@@AA@@@@@@AA@@@A@A@@@@B"],["@@A@@@@B@@@@B@@@@@@@@@B@@@@@@@@B@@@@@@@@@@@@B@@@@@@@@@@BBA@@@@B@@@@@@@@@@@@@B@@AB@@@@@@@A@@@@AA@@@@@@@@@@@@A@@@@A@@@@B@@@@A@@@@@A@@@@@A@@@@@"],["@@@@BB@@B@@@@@B@B@@@@@D@B@@BB@B@B@@A@A@@AA@@@AA@AA@@@@A@A@@B@@@@A@@@@@@@A@@@@@@A@@@@AA@@@@A@@@BB@@A@@@@B@@@B@@AB"],["@@AB@@@@@@B@@@@B@@B@@@B@@@@@B@@@@A@@A@@@@@@@AA@B@@A@@@@A"],["@@@B@BBDBB@@BD@BB@B@@@@@BBDDB@FDB@@@BA@AAAA@ACA@AA@AAA@ACAA@@@AA@AAAA@C@"],["@@BFBBDBD@D@BAB@@ABACC@ABAD@DBB@B@BABEDCBC@AAAAACBABA@A@A@AB@BAB@@AA@A@A@AEEAAAAAA@CAAA@@BA@@BAB@AA@A@C@@BA@@@AABA@AAAA@CBCF@DDB@B@BAB@B@@B@B@B@BBADCBC@A@ACA@AB@B@D@D@BABBBAB@@A@AA@CAAACAACB@@ABBD@B@B@BABBBB@DBB@BB@@AB@DBBD@B@BA@@DBBA@@@ABA@@BABA@A@C@AAC@C@AB@B@B@B@BBB@B@B@B@@B@D"],["@@@@@@@@B@@@@@@@@@@@@@@@@@@@@A@@@@A@@@@@@@A@@B@@@@B@@@@@@@"],["@@BBB@@@@@@@@A@@B@@@@@@@@@@@@@@@@A@@@@AB@@@@AA@@A@@@@B@@@@"],["@@A@@@@@@@@@A@@@@@@@@@@@A@BB@@@@@@B@@@@@@@@@@@@@B@@@@@@@@@B@@A@@@@@@@@@@A@@@@@@@@@"],["@@@B@@@BBB@BBBBD@@B@@@@@B@@@BA@@@@BB@BB@@BB@B@@AB@@@B@@@@AACAA@@A@@@@@@A@AA@@AA@@BA@@ACA@AA@CAAB@@@B"],["@@@@BB@B@@BB@@BA@@@@@@@@B@@@AA@AA@@@@@@A@@@A@AA@@@A@@B@B@@@B"],["@@@@BB@@@AB@@B@@@@BA@@A@@@@@@@@A@@@@A@@@A@@@AB@@B@@@"],["@@@B@BBBB@B@B@@A@AAA@@CAAB@@"],["@@@BBBB@@@@@B@AA@@@@@A@@@@@@@@B@@A@@@@@@@@@@@@@A@@A@@@@@@A@@@@@@AA@@@@@@@@@@@@A@@AAB@@@B@D@@BB"],["@@@@@B@@B@@@@@B@@@@@B@@AA@@@@@B@@@AA@@@B@A@@@@A@@A@@@@@@B@@@B@@@@@@AA@A@@@@@@@@@A@@@@@@@@@@B@@@@@B@@@@@@@B@@@@@@"],["@@@@B@@B@@B@@@B@@@B@@@B@@B@A@@@@@@@AA@A@@@A@@@A@@@AA@@@@@@A@@@@@@@@@@B@@@@@@@@B@@@"],["@@@@@@BB@@@BB@BBBA@@@@@@@@@A@@AA@@@@@A@@@@@AA@@@@@A@@@A@@@BA@@@@AA@@A@@@@@@B@@@B@@@BBB"],["@@@B@@B@@@@@@@@B@@B@@@@@@A@@@A@@@@@@B@B@@@@AA@@@@@@@@@@@@A@@@@@@@@@@A@@@@@A@@@@@AB@@@B@@@@@@@@"],["@@B@@B@@B@@@@@@BB@B@B@DB@@@A@@@@A@@AA@AA@@AA@@A@@@@@A@@@AB"],["@@C@@@AB@BB@@@B@B@@BB@@@@DBB@@@@B@@AB@@@@@DB@@B@@@@A@@A@@AAACAAA@@A@@AA@"],["@@BC@AAC@AB@AEBA@A@AEAABBD@FABCFABA@CBA@@B@DABA@EBCBBBBB@DBBB@B@@BFDD@D@@B@FBBF@H@JADCBE@CAAEA@@ABC@AAACAACA@CBC"],["@@@B@@@B@@B@@@@@@A@@@@@@@@@@@@@@@@@@@@@A@@@@A@B@@@A@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@B@@@@"],["@@@@B@@@@@@@@@@@@B@@@@B@@@B@@@@A@@@@B@@@A@@@@A@@@@@@@@@@@@@@@@@A@@@@@@A@@@@@@@@@@@@@@A@@@@A@@@@@@@@@@B@@@@@@@@@@@@@@@B@@@@@@A@@@@@@@@@@@@@@@@B@@@@@@"],["@@CD@B@BB@BBBBBABAB@B@B@B@B@B@D@@@B@@A@AAA@@BA@@AA@@AA@@@A@@@C@@AAA@AB@BA@KH"],["@@A@@@B@@B@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@A@@@@@@A@@@@@@@@"],["@@@@AB@B@@B@@@B@@@BA@@A@@A@@@@A@"],["@@@@@B@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@A@@@@@@@@A@@@@@@@@@@B@@@@@@"],["@@@@@@@BB@@@@@@@B@@@@A@@A@@@@@@@@@@@@@@@@@A@"],["@@@@@@@A@@A@@@@@@B@@@@@@@@@@@@@@@@B@@@@@"]],"encodeOffsets":[[[122712,27073]],[[122867,26893]],[[123104,26891]],[[123102,26881]],[[122918,26872]],[[122919,26870]],[[122887,26845]],[[122899,26847]],[[122515,26757]],[[122808,26762]],[[123295,26793]],[[122500,26759]],[[122762,27045]],[[122779,27057]],[[122794,27053]],[[122756,27019]],[[122755,26998]],[[122828,27009]],[[122848,27000]],[[122971,27014]],[[123107,26964]],[[123388,27005]],[[122780,26924]],[[122774,26924]],[[122776,26927]],[[122880,26870]],[[122896,26865]],[[122900,26866]],[[122857,26818]],[[122855,26792]],[[122703,26916]],[[122688,26897]],[[122685,26889]],[[122705,26880]],[[122597,26897]],[[122598,26867]],[[122549,26752]],[[122538,26773]],[[122532,26772]],[[122508,26742]],[[122846,26708]],[[122689,26858]],[[122686,26859]],[[122684,26858]],[[122684,26856]]]}},{"type":"Feature","id":"350124","properties":{"name":"闽清县","cp":[118.868416,26.223793],"childNum":2},"geometry":{"type":"MultiPolygon","coordinates":[["@@DAHAHAHA@AAC@CHE@@@A@A@A@@B@@A@AAABA@@@A@@A@A@AA@@@@A@BA@@@A@@AA@@A@@@EHAFADE@CCCCECEAGCCADEBE@EBC@CHBFBDBJGDAJIFMAOGMGKCUASAA@@ACAAAACC@AAA@@EIAA@@@C@IKCE@C@CCGAECAEAACACAAEACA@@@AA@@@BA@AB@@@B@@ABA@A@@AAAAA@@@AA@@BA@@@@@A@@A@@C@A@AAAAEIAA@ADCDC@CAEEEIC@@OAIA@CFIAMCOIIIGQIIE@GBIAICEAAAAAGBGBEBA@AGICMEMEOGGICG@@@ECEC@E@GBQBM@I@M@GBEBADAPCNALBFDAH@JBDFALCJAN@HDDBDDFHFFDBBHBDFDHDFBD@JCBCBG@EAEAECAECECCCGECGEEECEECAAE@EBG@CAECCAA@IBC@K@IAK@I@CGGECGCEACEAGCEEEEECGAEAGCC@CDCDCBEAECCEECCCC@EBCAEAECGAGAGAEBGBCAEAC@EHEBGAECIEGACGCEAKBGBGB@@KFGDCBC@CCCAE@C@AC@CBCBADA@C@G@CAC@@CCC@E@AA@A@CDEBIBGAEACEAA@CBEBG@ECACAE@EBABABA@AAA@CBA@ABABA@CECCA@ACAI@ABGBE@@@CBE@C@ACAK@@@@B@BA@@@@@AAAA@@@AB@@AB@B@@@@@@AA@@AAA@AA@@A@@@A@@@@@E@CACACECCCCAA@CB@DCB@@AAAACAEAEAI@ACAEAEAEC@CBA@A@AAAAAAACAAAAA@@@A@CBABCBABEACACAC@C@@D@BA@A@A@@CACAAAAAAA@@@AAAA@A@A@ABABA@C@EAC@C@@@@B@D@D@B@BC@EDADABBDBDD@BB@@CHAD@D@F@FBDBDA@@@C@C@E@AAACACA@CCBGAC@AA@AA@@BC@A@AAAC@CBEAGACC@@@@A@@@@@C@A@@@A@@@@@@@@B@@BB@BABAA@@AA@@G@CBCB@B@B@B@BADADCBCBA@AAAAAAC@ABABBD@B@DADCDCDEBC@AB@D@D@BB@BBAD@DABA@A@CCCEKEACA@@B@@@BA@@AC@AAAAA@CAA@A@CA@@CAC@C@IAKEKAE@ABCF@F@DDHDNBF@B@BGPADAB@D@D@FAB@@A@AAAE@CA@ABAB@B@BA@CAAAA@A@AB@@@BBB@DAB@DAB@@@BC@ABAB@BADA@C@A@A@AAC@AB@B@BACCCAECEC@CBAD@D@DA@AAEEEACAA@E@A@CCBABA@AAACEACCAC@C@CBEDADABA@A@AAA@@AABABABABA@C@@@A@CBAB@H@HAFCD@BCBCBE@EBCJAHBFDDFF@B@LBLCHEHAHAHBBH@TCfBJ@LBJBPBHBD@@@B@B@B@DA@@BABABABABCD@@ADABA@@JBHDEFIHBHJHBB@DBFBBCBGCGBAFANCPCBEFAN@L@@@BAB@BBDBBBB@BBB@BDF@B@BABB@BD@@@FCBCACAKA@AG@GFGNAT@LFL@@@@@B@D@B@B@BABAB@BBB@B@B@DBDABD@JEFADBDD@BCHCHAB@D@BBB@@@BB@@BBB@@BB@B@@BBA@@@@BB@@@AB@@@@A@@B@B@@@BB@@B@@A@@B@@B@@B@@@@@B@@@@@BBAD@@@B@@BB@@@@BB@@@@@B@@B@@@@AB@@BB@@@@BBB@D@VBHCFCDABAFLIHKTEFBBB@BBBBBBBBB@BBBB@B@@BBB@@BDARAV@FCHENGLAFFHDD@DADA@@@BBBBD@D@@BDBBDD@BBDCDF@BB@FBHAFAFAB@@ADAFAFAHBHAB@@HJNFHDBBBB@@@B@BCD@B@@D@D@D@@B@BD@BA@ABAB@F@DBBD@DABCBE@AB@BBF@F@F@FDDDDJFFFHDHHFHDFBFDDBDH@B@PAHB@AD@B@B@B@D@@@B@B@D@B@B@FABA@ENENCNAFBNJNHHDBF@HBHDJBJEHIFGFE@EBCD@@ABAB@BADABABABABABA@@DDDEFGFI@GBEDAF@@@@DF@F@DF@DBCHADBBFHBFEDQHA@@@CBABA@CBABOHGFDHDF@BBDAHAJBFBD@J@HBFBDFBD@BBFHFBFDFB@DBD@B@DA@@B@@A@C@CB@@@B@B@B@BBB@BA@@BABA@ABA@@@@B@B@D@@@B@BBB@BBB@AF@H@H@FBD@DCHAP@D@FEDC@EB@AECEBAJAPENEDG@E@G@E@G@A@@OK@CLILIDEACC@@E@KDIBAJGJAL@B@JDLDLFPJB@DDDFBDDDBF@FDBFBFDDD@D@F@DHBJDFBD@BBBBDBDBB@DBD@DBHBFBFBB@JAHBF@H@F@FEFGDEDADCHBD@BADBHFDLDPALEFGAG@EFAHDLHHHFBJBLFJLFRHLBT@FAFCDCF@DB@BBBFB@@@B@@@@@BABAD@@@@@BA@BDBDDB"],["@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@A@B@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@A@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@BA@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@A@@@@@@@@@@@@@@@@@@@@@@@@@@BA@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@BB@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@AA@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"]],"encodeOffsets":[[[121858,27181]],[[121678,27068]]]}},{"type":"Feature","id":"350128","properties":{"name":"平潭县","cp":[119.791197,25.503672],"childNum":90},"geometry":{"type":"MultiPolygon","coordinates":[["@@B@@@@@@@@@@@@@@A@@@@@@@@@@@@@@A@@@@@@@@@@B@@"],["@@A@ABABC@C@ABA@C@@@ABABABCBEB@@@BB@@BAB@BDDB@B@@AB@@D@BBB@BBBD@BC@E@ECEB@BAD@@BBBDDBDBBB@BB@DBFAB@@@BBBDBHBBB@B@@FHDBB@@@D@BBDB@B@BAB@@@BBBFBF@DA@@HBBBBDB@@A@A@CCA@CBCCMGGACBC@@AACB@@CA@A@EECA@C@CAEC@@CBAA@A@@BAAAAEIEC@"],["@@@@@@B@@@@A@AA@@@@@@@ABB@@B"],["@@@@@@@@@@B@@@@@@A@@@@A@@@@@@@@@@@@B@@@@"],["@@@@@@@@@@@@B@@@@A@@A@@@@@@@@@@@@@@@@B@@"],["@@A@C@@@@@AD@BABA@C@CCAB@@@CA@A@A@@A@@ABAB@B@@@@B@@@@B@BABA@CAC@E@A@@BAJBBBB@BA@@B@HBB@DAB@B@@F@FABABE@AAA@@F@F@DBBBFD@@DA@A@AA@@@AA@A@AAAAA@ABAB@FABBB@@BAB@D@BBBABAB@D@BBBABBB@BD@BA@A@AA@BAB@AABAB@@AB@BBB@BAAE@@AAB@B@@AA@AA@@@AB@BAAABABCACAAA@@AACABCA@AA@"],["@@@B@@BB@D@@CBC@@@A@ADAHAD@B@@BBJ@FB@@DAB@@B@@CDABA@C@@B@BDBD@F@D@FEB@D@FB@BCB@B@@BBB@B@@BBB@@B@B@FAB@BA@C@@CCA@@A@AB@@A@@AA@@FAHA@@BA@AB@BCA@CACC@@C@CA@A@AA@CAEBEAC@AAAA@BABE@CACCA@C@"],["@@C@GBA@@B@B@@B@BBBBAB@B@BBD@D@BABADABAB@HBF@BDDB@BB@DBDBBBBHFDBB@B@BC@EBCBCAA@AA@@@C@A@AAAABCBCBC@ABA@ABAD@B@DBBBB@BABA@ABCAA@ACAA@AB@BC@AA@AAA@@CAC@A@CAA@AAAA@C@C@A@@"],["@@@@@@@@@@@@B@@A@@@@@@A@@A@@@@@@@@@BA@@@@@@@BB"],["@@B@@@@@@@@@@A@@@@@@@@@A@@@@A@@B@@@@@@@B@@"],["@@B@@@@A@@@A@AA@@@A@@@AB@@@@@@AAAA@@A@@@A@@@@@@B@@BBBBBBB@B@B@"],["@@@ABG@AAEA@A@AAA@CB@BAB@HBD@@HDB@BA"],["@@@@@@BB@@@@B@@@@A@A@@@@A@@@@@@@@@A@@@@B"],["@@B@@B@@B@@@@@@A@@@A@@@@A@@@@@@@A@@B"],["@@@@A@@B@@BB@@B@B@@@@@@A@A@@@@@@B@@@B@@@@A@@A@@@AA@@AB@@@@@BA@"],["@@@BB@@BB@@@B@@@@AB@@AAA@AA@@@A@@BA@@B"],["@@@@@BB@@@BAB@@A@AA@@A@@A@@@C@@@@B@@B@@B@@@B"],["@@@B@@@@B@@@@@@@@A@@@@A@@@@@@@@@"],["@@@@BB@@B@BB@@@@B@BB@@@@@@B@@@@@@@@AA@AA@A@@@@A@@@@@@@@@AAA@@@AB"],["@@@B@@@@@B@@B@@@@@B@@@@B@@B@@A@@@@@AA@@AA@@@@@A@"],["@@A@@@@BB@@@@@@@B@@B@@B@@@@@@A@@@A@@A@@@@@A@@@@@"],["@@@B@BB@@@B@@@@A@@AAA@@@@@"],["@@@B@@@BB@B@@@@@@@@A@@@@AA@@@@A@@@"],["@@@@@@B@@@BB@@@@@A@@@@@@AA@@@@@@@@@@A@@@@@@B"],["@@DFDBDDFDDBD@BADGBCBADAFCBAACACEAC@AAAAA@E@C@CAA@ABA@@AAAA@A@A@ADADBHBH"],["@@@@B@@BBBBBBB@@B@@@@A@@AA@@@@@@AA@@@@A@@AA@@@@A@@A@@@@B"],["@@BB@@B@DAB@D@B@@A@@@A@A@@@AC@AAA@A@@@ABA@AAA@@@A@@B@@@BBD@BB@"],["@@DFFHJDFFF@DABAAC@C@A@ADAFBDBLDPBJDFBHJJDF@DA@EACCE@C@ADEBA@C@A@C@GAEECEAC@GBEFCDC@CAEEKAE@@BC@CCCAA@CBE@CACAABAB@BMJC@@BAHBD"],["@@@BBBB@@@BA@@@A@AA@AA@@AB@@@B@@"],["@@BB@@@@B@@@@@@@@@BA@@@@@@@@@A@A@@AA@BA@@@@BAB@@@@@@"],["@@@BB@B@@@BBB@@BB@@AB@@A@@@@@@B@BA@@@A@@@@AA@@@A@@A@@@CAA@A@@BA@@BA@@@@B@B"],["@@@@@@@B@@B@@@@@@A@@B@@@A@@@@@A@"],["@@@@B@@@@@B@@@@A@@A@@@@@A@@@@B"],["@@BB@@BB@@B@@A@@AA@A@@AA@@@@A@@@@B@B"],["@@@B@B@@B@B@BBB@@@BA@A@AA@@ABA@A@A@AAAAA@A@@@A@AA@A@A@AB@D@B@BBB@H"],["@@@BB@@@@@@@@@B@@A@@@@@A@@@@A@@@@@AB@@"],["@@@B@B@@@@B@@@@A@@@@@BB@@@@@@@@A@AA@@A@@A@@@@@A@@@@B@@@@@@B@"],["@@@@@B@@@@@B@@B@@@@A@@@@@@@@@A@@@@@@@@@@A@@@@@"],["@@@@@@@@BB@A@@B@@A@@@@AA@@@@@@@@A@@@@@A@B@@B@@@@@@@B@@"],["@@@@@@B@@B@@B@@@@@@@@A@@AA@@@@@@@@A@@B"],["@@@@@@@B@@@@@@@@B@@A@@@@A@@@@@@@"],["@@@@@@@@@@B@@@@@@A@@@@@@@@@@A@@@@@@@@B@@"],["@@@@B@@@@B@@BA@@@@@@@A@@@@@@A@@@@@@@@@A@@@@@@@@B@@@@"],["@@@@@B@@B@@@@@@@@A@@@A@@@@A@@@@@@B@@"],["@@BB@@@@B@@@@@@A@@@@@@@A@@@@@@@@@@@@@A@@@@A@@@@@@@A@@@A@@@A@@@@B@@@@@@B@@@@@B@@B@@@@"],["@@@B@@@@B@@B@@@@B@@AB@@B@@B@@@@@@@@A@@@@AA@@@@@@@@@A@@A@@@@@@@@@AB@@@@@@@@A@@@@@"],["@@BB@@@@BB@@BB@@BA@@@A@@A@@@@AA@@@A@@@@@A@@@@@"],["@@@@@B@@BAB@@BB@BA@AB@@@@A@@A@@@A@@@AB@@@@A@AB"],["@@@B@@@@@BB@@@B@@@B@@@@A@@@@A@@@@@@@@AA@@@@@A@"],["@@AB@@@@BB@@@@B@@@@A@@@@BA@@A@@@A@@@"],["@@@@A@@B@@B@BB@A@@B@@@@AB@@@@@@A@@@@@@A@@@A@@@AB"],["@@@@@@@@B@@@@@B@@@@@@@AA@@@@A@@@@B@@"],["@@E@@@@@@@@B@@@@@@@@@@@@@@AB@@B@@B@@B@@@@@@A@@@@@@@@B@@AB@@@@@@@BAA@@@@@@@"],["@@@@@@B@@@B@@@@A@@A@@@A@@@@@@B"],["@@@BB@B@@@@@B@B@@@B@@A@A@@@AA@AA@@A@ABA@@D"],["@@@@BB@@@B@@@@B@@A@@@@@@@@@@@A@@@@@A@@A@A@@@@@@@@B"],["@@ABABADBB@BBA@@B@@@B@@AB@B@@@B@@A@@@AB@@@B@@A@C@AA@A@CBCB"],["@@@BBBB@BB@BBA@@@A@@@AAA@@@AAAA@@@AB@B"],["@@@@@B@@B@@@@@@@BBB@@A@@@@@@AA@@A@@@A@"],["@@@BAB@@B@@@@@@@BA@AA@@@@@@@"],["@@@@@A@@@@@@@A@@@@@@A@@@@@@@@@@B@@@@@@@@@@@@@@@B@@A@@@@@@@BB@@@AB@"],["@@@ABA@A@@@ABAB@B@B@@A@@AAA@AB@@A@@AA@AAAB@@@B@B@@@@ABA@@D@@@B@@@@AB@@@B@B@@A@@@@@@BA@BB@@BBBA@@B@BABABC"],["@@@@@BBBB@@@B@@@@AA@@A@@@@AA@@@AB@@@AA@@@@@@A@@B@@@@@@@@@B@@@B"],["@@@@@B@@@@@@@@@@@@@@@@B@@@@@@@@@@@@A@@@@@@@@A@@@@@@@"],["@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"],["@@@B@BBB@BBB@@B@BA@@B@@@@AA@@@@A@@@@@ABA@@AA@@AA@@@A@@BA@@A@@AA@@@@B@@A@@@A@A@@@@B@BB@@@@BA@@@BB@@@@"],["@@A@@BA@@B@@B@@@B@@@@@B@@@@A@@@AA@@@"],["@@A@@B@BB@@B@@@BB@@@B@@A@A@A@ABA@@@@@A@@@@BA@@A@@AAB@@AB@BA@@B"],["@@A@@B@B@@BB@@B@@A@A@@B@@@@AA@@@A@"],["@@AB@@@BB@@@@@B@@A@@@@@@@A@@A@@@"],["@@@@@@@B@@@@@@@@B@@@@A@@@@@A@@A@@B"],["@@AB@@@B@@@@B@@@@A@A@@@@@@@@@@@@@@@@"],["@@@@@@BB@A@@@@@A@@A@@@@@@@@B"],["@@ABB@@@@@@@@@@@@A@@@@@@@@"],["@@@@@@@B@@B@@@@A@@@@B@@@@@@@@@@@A@@@@@A@"],["@@CBABAB@B@@@BB@BAB@BA@@B@@B@@@@B@@@B@@@@A@@@A@@@A@@AAA@A@"],["@@@A@A@A@@AA@@ABA@@B@@@B@@AA@@@B@BAB@@@@BB@@@AB@@A@@@@B@@@@B@@@@BA@@B@@@"],["@@@B@@@BB@@@B@@@B@@@B@@A@@@AA@@AA@A@@BA@"],["@@@@ABB@@BB@@ABAB@AA@AA@@@A@@@@B@B"],["@@AB@@@@@BB@@@BA@@B@@A@@@@@@@@@AC@@@@B@@@@@@"],["@@A@AB@AABABB@@B@@B@ABBB@@B@BAB@@@B@@@BA@A@@AA@@AA@@A@"],["@@BD@@@@B@B@BA@A@A@@AAA@@@A@@BAB"],["@@@B@BB@@@B@@@@BB@B@B@@A@A@A@@A@@ACBA@@@AA@B@@@@"],["@@BDBBBBB@B@@@BB@@BA@@AC@AA@AAAAA@A@AB"],["@@BDBB@BB@B@D@@@BA@A@A@@@AB@B@BB@@BA@ABAA@@A@A@A@@AAA@@AA@BA@@@@AAA@@BA@@@A@A@@@A@@B@@@B@@@BAD@@ABA@@B@B"],["@@AB@B@@B@B@@@B@@@B@@@BA@@@@@@A@A@@@@A@@@@@@@@A@A@@@"],["@@B@@@@@@B@@@@B@@A@A@@@@@@@A@@A@@@@@@@@@@@A@@B@B"],["@@@BA@@B@@@BB@@AB@@A@@@A@@A@"],["@@@AA@@@@@@@@@@@@@@B@@@@A@@@@@@@B@@@@@B@"],["@@HR@D@BC@ABAB@BBDBBFDBFVHBDBHBDDDJDJBJADADAF@FBDB@BBB@B@BSHAB@BDH@BADAD@B@B@B@B@BB@D@B@@V@D@D@@ABB@@BA@ADGTCJABCBABOFKDAB@@AH@DABCDCDAH@F@DDBBDDBDADBBD@FBDHFBB@DBD@@HFLFDBD@B@DAD@DB@DBD@HDHHFTJDBH@FBFBTLBB@DA@BB@@B@BAB@B@TLVND@B@D@BABADE@C@C@CCEOSIM@CACBCDOJMDAFAD@F@RFDBF@FAD@BCDCBAFCF@B@DABA@AB@HEDAFABADABADE@C@AAAAAAACAAA@CACEEAAAC@ABABAD@B@B@DCDABABCDAFAZGHAJ@D@DBVJD@D@B@BA@C@AAQCIGKYUKEGAE@C@CDADCHADCBCBCBE@AAMEYKGECCCMAGAK@KDODGBCFAHAH@B@DCBA@CBCBCBABADBJBDBB@FADABC@CBABBDBJDBDB@DABC@CAGBC@ECGCECEAA@ABC@A@AACCAG@C@EBABCLCFABCBG@GBGBGAECA@@A@A@@@AA@GACAA@ABA@A@C@AAA@ECEEKC[UGEIAGACCAECIAEBC@CBAFADAJBBABAB@B@@@JADABA@@@A@@@A@@@A@@@A@@AAA@EAA@@@A@@@@AB@@A@@AA@C@@@AAA@@A@A@@@@@A@BA@@B@@@@A@@@@@AAAA@C@A@A@ABA@@AA@@@AB@@@B@BA@AAA@AAA@A@A@A@A@IJGFCHAHABCBA@ABADA@A@@@A@A@CBA@C@A@@BA@A@ABA@ABA@A@EAA@AB@B@BEFCDCBGBE@G@I@C@@B@B@BD@D@FBF@BBBBAD@DADA@CB@AAA@AI@C@A@ABCBAFGDCD@D@BBBFFFH@D@BC@C@CAC@CDCFAB@D@N"]],"encodeOffsets":[[[122653,26290]],[[122450,26243]],[[122432,26267]],[[122588,26246]],[[122495,26224]],[[122778,26197]],[[122578,25962]],[[122568,25912]],[[122575,25918]],[[122572,25914]],[[122600,25884]],[[122600,25866]],[[122731,26321]],[[122734,26322]],[[122700,26286]],[[122700,26282]],[[122708,26284]],[[122643,26330]],[[122631,26281]],[[122600,26328]],[[122561,26282]],[[122566,26286]],[[122577,26283]],[[122575,26281]],[[122521,26281]],[[122487,26291]],[[122494,26291]],[[122535,26263]],[[122567,26229]],[[122671,26268]],[[122676,26263]],[[122686,26264]],[[122691,26237]],[[122726,26231]],[[122737,26209]],[[122786,26210]],[[122715,26193]],[[122722,26189]],[[122751,26184]],[[122691,26122]],[[122699,26124]],[[122696,26122]],[[122691,26129]],[[122701,26140]],[[122716,26129]],[[122542,26118]],[[122571,26142]],[[122580,26144]],[[122583,26146]],[[122578,26154]],[[122582,26156]],[[122580,26168]],[[122590,26165]],[[122568,26189]],[[122545,26107]],[[122532,26091]],[[122539,26058]],[[122556,26069]],[[122587,26026]],[[122681,26067]],[[122677,26060]],[[122686,26053]],[[122695,26033]],[[122693,26038]],[[122691,26034]],[[122818,26043]],[[122753,26083]],[[122747,26086]],[[122725,26100]],[[122650,26004]],[[122643,26003]],[[122634,25999]],[[122631,26000]],[[122628,26000]],[[122620,26011]],[[122588,25985]],[[122602,25961]],[[122579,25943]],[[122579,25951]],[[122570,25955]],[[122565,25953]],[[122556,25945]],[[122600,25885]],[[122619,25901]],[[122632,25906]],[[122646,25905]],[[122648,25899]],[[122586,25928]],[[122556,26196]],[[122548,26087]]]}},{"type":"Feature","id":"350125","properties":{"name":"永泰县","cp":[118.939089,25.864825],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@BGFCHCHEH@DDHBF@LFFDHBFDFDDBH@FAFAF@FDDBFBHABCBE@CAEAE@C@ACEAEBEDEHALEJGHCLDH@BC@C@CDCJCN@XFLFH@BABC@C@EBEDCDE@@DADFFDJAD@FAF@D@FCBCDAB@HDLALCHGJE@@@@LBJ@HALAFADE@ABCBAD@DAB@D@BABCBCHCJC@C@EEGEGAECEAA@@AAAE@GDCF@JDJFFDHADA@ADCBCCAKCCECIAKCICIAGBGBAD@DABABEDKFGDCB@F@F@DCBCCEICCE@ABA@@B@BBDBDA@@DAD@FBDBFBDDFHFDDBD@D@DADCBEBC@@DCBBFBBBDBD@DBD@H@@@@G@EHGLEJ@FBFABCBG@ACKEE@A@MDIDEJEHABCDEDEDCCCA@AAA@C@CAC@AAAECAECGACCAEACAAGA@@C@EAGAC@CAEAAE@AA@BA@C@ABA@@@ABEACGEGE@@ECAACAEACAA@EBCBEDA@EAEEC@EDGDGB@B@@BBAB@BA@@D@@A@C@IAGCGCE@CBC@EAAEA@@@EA@AAABCAEAACAEBCACA@CBABA@CEECAE@ABCFADCBA@ACACAC@E@A@CBCBG@A@@B@@@@@@@AAAAA@@A@C@@AAE@GAEAI@GAEEGEQBG@E@ECEAGCACMAO@O@ECCCABIBG@@@A@AAA@@@@@AAA@@AAAAA@@@ACEMCCC@AAEGCEAAAAD@B@H@HBHBDBDBDBFAD@HADABCD@D@HDDD@B@DB@DADCBC@GC@@AACA@A@A@A@AAAAACC@@A@A@C@AAA@A@A@AAAA@A@AA@AC@@AA@@@AAA@@CCII@EAEEAA@@BAA@@A@AA@@@@C@@@CAA@AAA@C@AAAA@@CAA@AB@@AA@A@A@@AAAAAAAAAA@AA@@AA@@@@@AACAAA@@CEECAAC@AAAA@AA@@@@@AAA@@B@@A@@B@@@@BDFHBDABABE@AAAAE@C@E@CAGACCC@MDADEBG@@@KHEDCDADADK@K@EBAAACAACAICAC@AD@DABA@AAAAAAACECEGCCCCAECEAGCEACA@@ICMBIDGHEFCBCA@CBEBGCGIGGAC@A@CEEGEEE@GBADBFJZ@J@DCBCAKGCEA@A@A@A@A@A@AAAA@@AA@AAAA@ABA@ABA@ABA@@B@@@B@B@@@B@@A@@@AAAAEDCB@@AB@D@D@@E@C@IAMBED@BBBDBDD@@@@ABCB@@AB@@@BA@ABABABODMBO@EA@@C@E@CAAAACAA@A@C@C@CAAC@C@@AEBEDCDEBA@ABAD@B@B@BABA@A@CA@EDI@C@@CAED@@CA@CBG@GAGEAGAADELABGACA@MCGCACHCHEBEAAC@CJICCCAC@INUKIFOMACAC@ADC@@AACC@@GCE@M@A@CACBA@@DAB@DABCBABABCDADCFABEDABAAABCBAB@DCBADC@CDABAB@D@B@DCBABEDCBADCB@B@B@BADC@CBEBCBE@EDCDCBABADCDA@CBECCAA@C@CBCDEBCDCDEFCDABADAD@DAD@D@D@D@DBB@@@FALCHEFCBABAD@BAD@BBB@BCL@HCLEJGDKDGFINADC@ICCDAB@FHHNP@@@DBD@DBD@B@B@D@D@BBB@DBD@BD@HCDAHDHHDFB@D@BBDBBB@@@B@BAB@DABABADAB@DADADAD@B@BABEDEBADBDDBF@@BAD@DABBDBBH@F@BDAFAD@@DFHHDFFHFFBDDDDADAFEHEFCHEBABC@@BAFGFAFCBCAIGo@ABA@@B@FFBBF@B@F@B@DDBD@DBR@DABAB@BAB@D@BAFA@A@AFBDBBDDDBDBD@DADCBAFAHAF@F@BADAD@F@D@B@BABCDCBE@A@AA@@AD@D@DB@@@B@BCDCBADADABAF@BABA@@@A@@@@B@@DBBBBBAF@D@BBD@@@BBBBBFJDDDD@F@DAB@@C@C@@@@B@BABBD@@BD@D@@@D@B@BBBBB@BBDBB@BAB@B@BBBBB@B@BCBABABAB@@AB@@BB@B@@BB@B@@BBBB@BBBAB@BA@@@AB@D@B@@A@A@@BA@@@@B@@@BDHBBDHBHCL@F@FADEB@L@BD@B@B@@BFAF@DADA@ADCBE@G@GBADAB@@@D@B@BABABABA@BB@BBB@B@BABCFCDAD@D@DBBDDFBB@BABABDDB@F@B@DBFBFFBBB@@C@CBCDAD@DFBFDDBD@A@ABAD@BBB@B@D@B@BC@ABABAD@@A@@BA@CBA@CAA@A@@BAB@B@BBDBB@@A@ABABAB@@DBFBBB@@@BA@E@C@CBABCHO@A@AAECMCG@C@EDEBAF@LBLFJBD@D@DB@@DBB@B@DBB@BBBBD@@BB@@A@@@AB@BDLFDFDDB@B@BA@CBCAAA@@A@C@CBAD@FADCDCBC@C@AACBABAD@BBBBBBB@DADABCBC@A@A@A@ADADAH@@@BB@@BBBA@AAA@@@A@@@@@@B@@@B@D@@@@@B@@@@@DDHBFBDAD@BB@B@BAD@@BBB@@BBDAHDDB@BDBDBBF@D@D@@@B@ACAC@E@E@CBCDG@@AAC@ACACBABCFCD@@A@A@C@C@A@@D@D@FBD@B@BABAB@B@B@BB@B@@BBBBBBDBDB@@@B@BABC@@@@DBDBDBDAFABADAB@D@B@@BBBBDBBBBBBB@B@BAB@DFDFBFBDB@BBJBFBFBDBB@BA@CDA@@DBBDDDDDFDBDBF@@@@@B@@@B@@@BBB@BB@@BB@@@@@@@ABA@@BA@@B@BB@B@@@@ABA@@@@@BLBDD@F@DA@@F@HABAJ@DB@BDBFD@DABAB@BAB@DBB@BABABAB@FBFBDFDH@FADAB@FBBDBFAHAJCF@D@BBBF@D@DD@@BD@D@H@DCBABAD@DBDD@F@DBDDD@DAHCLE@@HAHA"],"encodeOffsets":[[121726,26689]]}},{"type":"Feature","id":"350181","properties":{"name":"福清市","cp":[119.376992,25.720402],"childNum":51},"geometry":{"type":"MultiPolygon","coordinates":[["@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@A@@@@@@"],["@@C@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@A@@@@ADBABBB@BA"],["@@HFDDDF@@FB@@B@@@@AAABACCCIGIAAA@AAC@A@AB@BAB@BBBBBDD"],["@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"],["@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@B@@@@"],["@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"],["@@@@@@@@@@@@B@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@"],["@@B@@@@@@@@AA@@@@B@@@@@@@@"],["@@@@@@@@@@B@@@@@@A@@@@A@@@@@@@@@A@@@@@@@@B@@@@B@@@@@"],["@@B@@@@@@@BA@@@@@A@@@@@@@A@@A@@@@@A@@@@B@@@@@B@@@B"],["@@@@@@@@B@@@@@@@@@@A@@A@@@@@@@@@@@A@@@@BB@@@"],["@@@@@@B@@@@@@@@@@A@@@@A@@@@@@@@@@B@@"],["@@B@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@A@@B@@@@@@@@@@"],["@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@"],["@@EJA@A@CAA@A@ABADBBBDBD@DAFADA@@B@@@@A@AD@@@@@B@BDBD@HAHAFAD@DFDJDFBFAFADAD@@B@DAFAF@B@@BBBBBB@BBBB@BAD@B@DBBBDBF@B@DAD@BADCDADADCDABABAD@B@B@H@DABABCBAD@F@DAD@B@@CAEECACA@@ACEAEECCCAEEACA@@@A@@D@D@DA@CBE@EBABABA@GCA@EBCBCDADCFADEBC@CBAF@BAH@B@@CFEDGFADBBBBFBD@BADEFCB@BHAH@DAB@BABA@A@@@A@B@@A@A@A@@AAA@A@A@@@A@@BDL@DADEB@@EBA@A@@B@@@B@B@@@@@@@B@@@@BB@@@B@@@@@BB@@BCB@@ABA@@BAD@B@B@@@BA@@@@BA@A@@@A@@@EDGFCFCFEF@@@B@D@B@BAF@JDJFJDJBFDDBF@FAF@BFBHAJ@BB@BCDEBC@CDEFAJCJBDNBDBBDADADADCAA@A@@@@@@@A@@@@B@B@B@@@B@B@@A@@@@B@@CBA@@@A@@@@@@@A@@@@@@@A@A@A@@@@B@D@@@@@B@@A@@@AA@@A@@@@@A@A@@@@@A@@A@@@@@@@@BA@@@@@@AAA@AA@B@@@@@@A@@BA@@@@A@@@A@@@@@@AB@BBFHFNLBB@@B@DB@@@@BBB@@BJFDFDHBBBD@DABCBEBE@A@EBA@CBCDADA@A@CCEAAAABADABABK@K@IBG@EAGECAAACBAD@FABA@CACAAECCC@C@CBCB@@ABAB@B@D@B@@@@@@A@@@@BAHAD@D@B@FBDBDBDB@DABCDEBAF@DBFF@DABAB@DDBDBFADBBBBFADBB@BFB@@B@BFFBD@DAF@HDHDJBD@B@@@@CB@@ABAAA@@@AHAHCFCD@FFFBB@FCDAFAB@DBFBDBBBFD@@HFHFBDAF@B@@AB@B@DABB@@BBFFBDBD@HBFBD@@@HBBBBDBFDDHBFDDBBFBBD@DBD@B@BBB@DD@@BB@@BABADCB@JEJKDEDA@BBFBP@B@@@B@B@B@BBBBBB@B@@@BABABBD@B@@@B@BBD@B@BADA@@BAB@BBBBBB@@@B@@BB@@@@BB@@B@B@BABBLHJDHBB@@@B@@C@GDGDG@G@EDEHCD@@@DBD@FDDDBBBDDDFDDBDABG@C@CDCDCDEBE@CBEDAFAD@D@B@FCJGFEFCH@FFHHFBHAFCF@@A@@BABC@A@A@A@ABABA@C@A@@BAB@F@B@B@D@D@F@D@B@@BB@BD@BBDBDBFFDBDDNBFBDDFFFBDF@FDDDDFDBDDD@BABA@A@CBEDC@E@ED@DBFDD@B@DCBAJEHCFAB@@ADC@CAEACAE@ABABAD@DAF@DAFABA@@BC@CBC@AB@F@D@HBB@@@D@JBHBBDB@B@BAB@@AFAD@BBBB@@B@DBBABABAF@FBF@FBB@@@DADBBD@DD@BAFAHADADABCBAD@DBDABC@EACACCAE@ECAA@ADA@@@@BC@@CCECAAAADC@@BCAA@A@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@A@B@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@A@@@@@@@@@@@@B@@B@@@@@@@@@@@@@@@@B@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@B@@@@@@@@D@@A@AB@F@DB@C@CBCFAF@H@JCHBFADABA@@DAFAFADADADA@A@ACACAAA@A@A@C@CACAECCAAACAC@CAE@CACBCDEBEDCBCDAB@DBBA@AACAA@@@A@@@@AAAEAE@GBCBGSB_F]BO@QA[GKAGCOAIC@CAGEAGCKBGEAE@IDGDEBKBIAIBA`BFCBCFEFAJFF@^EFBDFDDJ@FCBGAG@E@CBCDI@G@AAAAACCACCAEE@@@A@AA@@A@@DKB@B@@@B@B@B@DAB@FAFAD@FBH@D@J@DAFADBFBJDPNJBD@H@DABCFE@CACCM@ABAHEHEBABGDIHC@GAGFSBCBE@ECGGGCCAC@G@IDMFELKFIDC@E@EGE@A@C@CBADAJ@DBBBFFDFFFDDDBFBB@DABA@EAKBK@AB@lJ@MuMEAAA@GCK@CCEIEOGG@CC@CDCDAD@F@FADAB@F@BBBF@BB@B@D@FCDED@DAD@@@@FAH@B@DBBB@D@BBBAB@B@BBB@DABADE@G@G@CBCBC@A@ACEAA@E@E@AAAA@A@AACBCBC@CA@C@C@CAC@E@CDGFK@CDC@C@A@C@CDA@ACCCA@CBAAAA@CDCDC@EAGGECKAEACACAC@@A@A@A@@DAD@FBF@F@LDHDDDDDB@D@@@BA@@@A@A@AAC@AAA@CCCACAAAAA@AAAA@CCAEAEAGAECE@C@E@EBC@C@ABMBC@AAAAEAACCAEAC@C@ABCHCDGJ@D@DDBBBD@D@B@@@@BCDILCFELCJ@D@HBFBDDBDFDRCFAH@F@BABA@ABC@@DCB@B@D@D@DBDDDBB@BABA@EDCB@@AB@BBBBD@B@NAFADCDCBG@EAEAEECEBEAGCEAGBCFEB@DADADE@E@CBA@@B@B@D@DBBCBABEBEDG@A@ACACCAAEAEAAEACAE@AA@@AA@CCCAABE@CAAAAA@A@C@A@AA@@@AAA@@@@A@ABA@A@A@AACA@AAA@CAC@AAA@CACAA@AAA@AB@@@@@B@@@D@B@BBBBB@B@D@D@DEBEBGBGAKAGIGAGCA@AA@CACAE@AA@A@GBIFABAB@F@DDFFJLJRNDD@D@D@BADCHQVGFEBA@ABAB@HBFBLFRBHADABABEBE@A@AAC@E@G@IBE@A@AACIEKACEECECCCCG[EACDBTCJMJAD@DPJTT@HABEBABA@AD@DB@BVBFDBDFJ^AFGDMBI@OSAAEAiHCBABATABCDsVIFCBEBEAC@ACCEGUKsAODOFODIJO@EBI@G@EACCCI@CECBCDGHO@IGG[IEIDM@GAG@SBWTOJKVA`JZJRHFCDC@A@A@AA@@CAA@AAA@A@EBCBAB@B@N@F@@A@@@GEaSECAA@A@C@A@@AAA@CBA@E@C@AA"],["@@@ABAA@@AA@@A@@A@@@@@A@@B@@BB@@@B@@BB@@@@B@"],["@@@@@@@@@@@A@@@@B@@@@@@@@@@@@A@@@@@@A@@@@@AB@@@BB@"],["@@BB@@B@@@@A@@@A@@@@@@@@BA@@@@A@AA@@@BA@@@@B@@@@@B@@"],["@@B@@@@@@@@@@A@@B@@@@@@@B@@@B@@@B@@A@AA@@AA@A@@@AA@B@@AB@@AB@@@BBB@@"],["@@DB@@@B@@B@@B@@@@B@@B@@B@@@@AB@@@@AA@@A@@@@AAA@@@@AA@@@A@@@@@A@@@@B@@"],["@@@@@@@@B@@@@@@@@@@@@A@@@@A@@@@@A@@@@@@@BB@@@@"],["@@B@BB@@@@B@@@@@@@@@@A@@A@@@@@AA@@@BAA@@@B@@@@@@@@@@@@"],["@@@@BB@@@@@BB@@@@@B@@@@A@@@@@AA@A@@A@@@@@@@@A@@B"],["@@@@@@@@@@B@@@@@@@@A@@@@A@@@@@@B"],["@@AB@@@BA@@@BB@@@@B@@@@A@@B@@A@@A@@A@@"],["@@A@@B@BB@@@B@@A@@@A@@@@A@@@"],["@@@B@BBBB@@AB@@@@@B@@@BB@@B@@@@@@C@@@@AA@BA@@@A@@A@AA@@AA@A@@B@B"],["@@A@@@@B@@@B@@@AB@@@@@@A@@@@@@"],["@@B@B@@@B@B@B@@@@@@A@@B@@AA@@AA@@A@@@@A@@@@@@@A@@@@@@@A@@@A@@@@B@@@@BB@@A@@B@@@B"],["@@@B@B@@@B@@D@BAB@@ABA@@AA@@C@A@A@@@@@@B@@"],["@@@B@BB@@@B@@A@B@@B@@@@@BA@@AA@@A@BA@@@AB@@AAA@@@A@@@A@@A@@@@B@B@B@@AB@@@B@@@@@@A@@B"],["@@@@@@@@B@@@@A@@@@A@@@@@@@@@@B"],["@@@@@@@B@@@@@@@@B@@@@@@@@@BA@@A@@@@@A@"],["@@@@@@B@@BB@@AB@@@AA@@A@@@A@A@@B@@@@B@"],["@@@@AB@@@@@BB@BA@@@@@AA@"],["@@BBB@@@@@B@@@AA@@A@@@A@@@"],["@@@@@@@B@@B@@@@@@@@A@@@@@@@@@A@@@@A@@@@@@B@@"],["@@AB@BB@@@BA@@@BB@@BB@BB@@B@@A@A@@@C@@AA@@@AA@AA@@AAABA@@@@B@@BB@B"],["@@AB@BB@DBBBB@@@B@B@BA@@@A@@A@AAAA@@@AAAA@ABAB"],["@@@@BB@B@@@B@@B@@@@CBAB@@@@@@A@@AA@@A@A@AB@B"],["@@A@@B@@@@@B@@@@B@@@@@@A@@@@@AB@A@@@@@"],["@@@@B@@@@@@A@@@@@A@@@@A@@@@BA@@@AA@@@B@@@@@@A@@@@@@B@@@@@@@@B@B@B@"],["@@ABABA@A@@@A@A@@@A@A@A@@BBB@@B@@B@BAB@@BBB@B@@BBB@BB@BBAB@BBBDBBBB@B@B@DBFBDBB@B@DB@@@A@@@CAE@C@C@ACC@A@AFEBC@AAAAAE@CBABC@A@E@AAAB"],["@@B@@BB@@@BAB@@@@A@A@@@@AAA@A@@BA@@B@B"],["@@BD@@B@@@@@@CA@@@@@@A@@@@@@@@A@@@@@A@@@B@@@@B@@@@"],["@@AA@@AAA@@@@B@@@@BB@@@@@@@B@@@@@B@@BD@@B@@@B@@A@@B@@AB@@CA@A@A@"],["@@@@@@@BB@@A@@@@@@@@@@B@@A@@AA@@A@@@@@AB@@@@@@BB"],["@@@@@@@@@@@@@BB@@@@@@@@@@A@@@@BB@@@@@A@@A@@A@@A@@@@@@@@B"],["@@@@@B@@@B@@@BBB@B@@BB@@B@@@BBB@@BBBB@@AB@@@AA@@AA@A@@B@@CBAB@BADAB@@@BA@@AAC@@@A@AB@BG@I@"],["@@@B@@@@@B@@@@B@@A@@@@@@B@@@@@@A@@@@A@@@@@A@@@"],["@@AB@@@@@B@@B@@@@A@@@@B@@@B@@A@@@@A@@@@@A@@@"]],"encodeOffsets":[[[122367,26411]],[[122412,26381]],[[122450,26285]],[[122483,26194]],[[122330,26023]],[[122528,25978]],[[122375,25975]],[[122375,25972]],[[122337,25968]],[[122386,25960]],[[122491,25946]],[[122489,25944]],[[122479,25933]],[[122477,25932]],[[122082,26080]],[[122416,26230]],[[122414,26223]],[[122478,26197]],[[122473,26208]],[[122479,26187]],[[122500,26143]],[[122499,26129]],[[122497,26125]],[[122495,26125]],[[122519,26069]],[[122511,26041]],[[122548,26022]],[[122542,26007]],[[122539,26005]],[[122438,26056]],[[122436,26036]],[[122442,26033]],[[122438,25999]],[[122455,26007]],[[122420,25975]],[[122403,25968]],[[122376,25971]],[[122470,25938]],[[122346,25914]],[[122355,25916]],[[122358,25920]],[[122351,25932]],[[122342,25940]],[[122331,25960]],[[122336,25979]],[[122230,26022]],[[122230,26020]],[[122245,26043]],[[122256,26046]],[[122280,26060]],[[122299,26064]]]}},{"type":"Feature","id":"350182","properties":{"name":"长乐市","cp":[119.510849,25.960583],"childNum":19},"geometry":{"type":"MultiPolygon","coordinates":[["@@H]BEFAHBLDXJH@F@NERGLODM@GAaCUEWCIQkGUGYCQCICIGCKAGAOAWAS@MCICEEEGGWGeAS@I@GD{BkB[@CHIBCH@BEBIAGCEQKEIEECAIECC@CCIAAAAA@AC@AC@AA@C@AB@DAB@BABA@C@ABAB@BA@@@A@@@CCECGEICGCAMGUAAHAD@HBFBFBB@@@@@B@@BBBD@BABCAA@CBADCDAFCFADBD@DBF@DBDBDBBDDBFBD@D@D@B@BBBDBDB@B@BCBCBCBEBEBCB@@ABCBEBGAIDG@E@EBAD@D@DCAE@A@@B@BABA@AAAB@@CDBBBBFDDD@@AD@@@@CB@BBBFDF@DBBDBD@FADCBCAC@ABADCBCBGBEBABC@@CACCACB@@A@EAE@EAE@ABABABCAA@@@AAAAC@EB@B@@@@@@@B@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@AAABA@A@ACGAIAC@@@A@GAC@E@A@@BAD@DAD@@ABEBCBE@CBC@ABAB@BBFBDBF@DCD@BA@EBGDIFABCDA@C@ECCAC@@F@FCDAF@D@BABABC@CCCACECCECE@AC@L@HCDED@JBDLFHNFLFJBDAFEHAB@DAD@D@BRF@FEDAFB@DB@BBB@DAFABAFAD@D@D@F@D@HAB@BA@CAA@C@A@C@CDAJAJCLEN@@DF@BBF@DBBHJAB^@NBTFLFNHRLDBFDFBFDJFBDDDDDBBDFBBBB@@@B@DPXJPPVDR@NDHFHNPLNNJLDNAJCHIHSFELENA@@@@PAVBRA¼K"],["@@@@@@@@B@@@@@@A@@@AA@@@@@A@@@@@@@@BBB@@"],["@@@A@BA@BB@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@"],["@@@@@@@@@@@A@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@A@@@@A@@@@@@@@@@@@@@@@@@AA@@@@@@@@@@@@@@B@@@@@@@B@@@@@@@@@@@@@@@@@@@@A@B@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@BBB@@@@@B@@@@@@@@@@@@@@@@B@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"],["@@@B@B@B@BCBAAA@A@EJAD@D@B@@DDBADBF@DCDBBBNBB@@A@A@@FB@@DC@AEEAAEC@AA@C@A@@@A@BC@@A@AAAC@@CAA@"],["@@@@A@@B@@@@BD@BBD@BB@@BA@@@@@@B@B@@D@DBBBBBBF@DBB@@DDDABBD@@A@AB@BAB@BB@BBDB@BBDABA@A@A@@CACC@ABA@@@@AAA@A@CCA@@@A@@@@@@ABC@@AA@@A@@@A@@@AA@@A@@@@A@@@A@@@@CB@@AD@@@@@@A@@ACACE@@A@@@@@AC@@A@A@"],["@@@@@B@@@@@@@@@@B@@@@@@@@@@@@A@@@@@@A@@@@@@@@@@@"],["@@@@BBB@@@@@BAAA@@@@@A@@B@@AA@@A@@@@@@A@@@@@AA@@A@@@@@@B@B@@BB@@@BB@@@A@@@@@@B@@"],["@@@@@@@@@@@B@@@@B@@@@@@@B@AA@@@@@@@@@@A@@@@@"],["@@ABAD@B@B@@AB@@@B@B@BDBB@@@@@@AB@@@@@@A@A@@@@@@BB@@@@B@@@B@B@BBBA@@@AB@@@B@B@@@@A@@AA@AA@@@@@@@@@@A@A@@B@@A@AA@AA@@C@C@EB"],["@@@@@B@@@B@@BB@@BBBBB@@@B@@@@A@@@@A@@A@@@AAA@@A@@@AA@@A@"],["@@@@@BA@A@AB@@@B@BB@@@B@@@@@B@@AB@@@B@@A@@@A@A@@A@@@A@"],["@@@@@@@@@@@@@A@@@@@@@@@@@@A@@@BB@@"],["@@B@@@@@@@@@@@@AA@@@@B"],["@@BB@@B@BB@BDB@@B@@@@A@AA@@AA@@@@@A@@@AAA@A@@@"],["@@DDDFD@BBBA@AB@BBBBB@B@@@B@@@FFDB@@DA@@@AGGCA@@A@AA@AAAA@@BA@A@AAAAACCACAA@@B@@BB@BA@AB@B"],["@@AB@B@@BBB@@@@@BAB@B@@@@@@@@AA@@AB@@A@@A@@@@A@@A@@BA@@@A@@B@@@@"],["@@@@@@@BB@@@@A@@@@@@@@@@@A@@@BA@"],["@@B@BBB@B@@A@@@@@AB@@@@A@AAA@@@@A@ABADA@@@@B@@"]],"encodeOffsets":[[[122536,26669]],[[122597,26600]],[[122367,26411]],[[122410,26381]],[[122816,26587]],[[122847,26569]],[[122877,26603]],[[122846,26566]],[[122535,26397]],[[122546,26375]],[[122564,26378]],[[122528,26369]],[[122686,26379]],[[122534,26303]],[[122539,26306]],[[122511,26289]],[[122483,26327]],[[122477,26331]],[[122496,26319]]]}}],"UTF8Encoding":true});}));
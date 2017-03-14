(function (root, factory) {if (typeof define === 'function' && define.amd) {define(['exports', 'echarts'], factory);} else if (typeof exports === 'object' && typeof exports.nodeName !== 'string') {factory(exports, require('echarts'));} else {factory({}, root.echarts);}}(this, function (exports, echarts) {var log = function (msg) {if (typeof console !== 'undefined') {console && console.error && console.error(msg);}};if (!echarts) {log('ECharts is not Loaded');return;}if (!echarts.registerMap) {log('ECharts Map is not loaded');return;}echarts.registerMap('nanchang', {"type":"FeatureCollection","features":[{"type":"Feature","id":"360104","properties":{"name":"青云谱区","cp":[115.907292,28.635724],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@L@F@@@@@@@D@@@@@@@FA@@B@B@D@@@@@@AD@@@@@BADAPE@@B@@ADKDEACB@BABAAK@K@K@CACE@IA@@C@@A@@DA@A@CAACECAC@CA@CAABA@@B@@A@@@A@@AAAA@A@@ABA@A@C@A@A@@B@@A@A@ABAB@@@@@@ABC@A@A@@AAA@@@A@A@@A@@@@@@@@BAAA@@@@@@@AB@AA@@@A@BCAAAAA@@A@@@A@@@@C@@AAEC@A@@@@@A@C@@@@@@D@@@@@B@@@@@BBH@@A@@@@D@@C@CBABCBABIFB@@@@BAB@B@@DB@@C@@@AHCD@BCB@@@@@@AD@@@B@BB@@@BBFFBD@@@B@B@BB@@BBB@B@@@@@F@@@B@@@D@BAB@@@B@@@B@@B@@@B@D@B@B@@BB@@@@B@@@B@@@@@BB@@B@D@B@B@DAD@D@BAD@@@@B@@@@@P@F@B@B@@@@@@@F@B@@@@@D@@@@@@@@@D@"],"encodeOffsets":[[118702,29343]]}},{"type":"Feature","id":"360105","properties":{"name":"湾里区","cp":[115.731324,28.714803],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@@C@CBABAD@DABC@CAAAEAC@C@CBA@C@@@AAA@AA@@CA@@A@A@A@ABC@A@A@A@ABABEBC@C@AAA@AACEAACAACEAEACACAD@B@B@BA@@A@A@@@@AA@A@AA@@@@D@B@@A@@@@@@AB@@C@@A@@@@@B@@A@@@@A@@@@@@@CA@@ABAB@B@@BCA@@@@B@A@@B@@AB@B@@@B@@ABA@@@C@@@ACEAAAC@@@A@@@AAA@A@AA@A@@AAA@C@A@@@AAA@A@C@@@ABCBADBB@BB@@BBBDDFBBDDD@@C@C@A@CAG@CBCFBFBDBDBBBJLBBFA@@BB@@B@B@B@BAAA@@@A@@A@@@@ABAA@@@@@@AA@@@AA@AAA@ACAAC@A@@@A@CBCA@EAAAA@C@C@@A@@AAA@A@@@A@@@@ABA@ABC@@@A@ABA@A@@B@BABABAB@@AAE@AA@@A@BA@A@@AA@AA@@@A@AA@AA@@@CAA@A@AAAA@AA@@@AA@@AB@@AB@BC@A@A@@@@BA@@AA@A@@BA@@@@@A@@@ABAA@AEAA@A@@A@A@@@ABA@AB@@A@A@AB@@@@AAA@A@@@EBA@A@A@A@MBCDIHCBCBCBEDEDC@EBEAE@CCCCCEEGCEAC@ABEB@DEBADATKFCLKDQ@S@K@IIIIQAQKGCA@@@@A@@@@@OAOD[JYHGJBNCPGJA@EAECEEC@AA@BCB@@A@@AACAA@@@@A@A@@A@@AAAAA@@A@@A@@@GBCBA@@@C@ADCBABEFD@BB@@@@ABA@CBA@AAA@A@CAAAACAAAA@@A@@@@@AA@@@@@A@AB@@@BABA@@@A@A@@@AAABA@ADABADEA@A@A@@@AA@@A@@@@B@@@@A@A@AAA@A@CDABCBG@CAC@@B@D@B@B@DAB@B@B@BAB@@BD@@FBBBBB@@@BBB@@BBBB@B@@B@D@@BBB@BBB@@AFAB@@@DAB@BBB@@B@BB@@BNALKPCDMJ@HFLLPJPHPHRBL@DBF@DDF@D@D@D@BBBB@D@BBF@BABA@@@A@A@AAAAA@@@ABEAAA@@BAAA@@@@A@@@A@@AABAA@@@@@@AA@A@@@@A@@@A@@@@@A@A@@B@@A@@@AB@B@B@@BBB@@B@@B@@B@@B@B@@@@@B@@BB@@@AB@B@BBFLHJFDDBBBDDBBD@B@@@B@BB@@@@@B@@@@@@C@@@@@@B@@BB@DB@@@B@@BB@BA@@DAFAF@BDDH@@@BAB@B@@@BBB@@@BA@@@CB@@ABA@@@BB@D@B@B@B@@LDD@B@BAD@@A@@B@BE@@BAB@@@B@B@@@DAHCFABA@AAAAA@@AA@E@@@@@A@@@@@@B@@@BD@@@BBBDBB@@@B@@AB@BAB@@@BE@@BBBBB@D@@@BA@@FA@@B@B@B@BBD@BBBB@DAB@@AB@@CB@@ABA@@B@B@D@@@B@B@BBB@@BBBB@B@@A@A@ABA@@D@@@D@@@BD@@A@@B@@@BBBD@DBB@B@@DBBBD@DADABBADCFAFABADGDABCBCB@BCB@DAF@BBBBB@DBB@@@@@@BBFAD@B@@@B@B@B@@@B@D@DA@@@@B@@@@B@@A@@BA@AB@@A@A@@@@@@B@B@@A@DD@@@BADB@BAD@B@DBBBBDBBBBDBB@DBD@BADAD@D@HDD@F@D@DAB@D@BBDBDDDDBBDBBBB@D@DB"],"encodeOffsets":[[118595,29603]]}},{"type":"Feature","id":"360111","properties":{"name":"青山湖区","cp":[115.949044,28.689292],"childNum":2},"geometry":{"type":"MultiPolygon","coordinates":[["@@BBBB@@@B@@@BA@@@ABBB@DDBD@DBDFBB@D@BCB@@@BD@@@JBF@BD@D@L@LBLABABA@BDCFCL@BA@@@OFCBAB@@@@C@@B@@@@C@A@A@@@EB@@@@@@C@@@@@@@E@K@@H@P@PF@@@@@B@H@AT@BBB@BB@BBBD@@@B@B@@C@BB@@B@@@@B@@A@@AAAA@@@A@A@CD@@@@@@BBB@@BB@@BBDBB@@B@BBBBB@B@@B@@@B@@BBAB@@@BAD@D@D@B@BHJDH@@FBDB@DJFLFLBRBNCLCPEREJ@F@BABGAE@GCCCEGKAGACC@@@@@A@@AA@A@@A@AA@AAAA@@AE@A@C@AAAAAAAAAAA@A@A@@BABAAC@GEIDA@@@@@A@AHB@@@@B@@@@@B@B@JBHADAB@D@@@DA@@@A@@@AB@BC@@@@@@BC@ABABADEB@DABADGDCB@DAD@BAB@HBDBDBB@@BBD@DBBBBHFBDDBAI@E@C@G@GBCBA@@HEB@@@DA@ADC@AB@AAAA@@BGAA@@A@@@@AA@@C@A@@AAAA@A@A@@A@AA@A@A@@CBAAC@@A@@CC@C@A@C@AAA@AC@A@GACAECAACAAACAA@AAAA@ACC@AC@EAAA@@EACB@@A@A@AB@@@D@@AB@B@@@@@@BB@@A@@@A@CA@@@@@A@@AAA@AAA@@@A@AB@@@BCB@@A@@@@@A@@BA@@@EBC@A@@A@A@ACCA@C@C@@@@@@BABCBC@AAA@EBA@@BABIBAFCBC@CAOEE@C@A@@BA@CB"],["@@ABABEBADA@@@CEEAICCAAAAA@AAECA@@I@@BA@@@@@@@AF@@AAACCAC@@B@FBD@FADABC@CBABABADADABCBEDCBC@C@AC@ACAA@CBEBE@AD@DBB@DABABADGHABEDCBABCBAB@DDHABADABADBDDFBF@DAB@DCBCDNAB@B@B@B@FA@@B@B@BB@@@@BAB@B@@@BAB@BA@@B@B@@@@BBBBFB@AB@B@@@B@@@@AB@@@BBB@@AB@@@@@B@BADA@@BA@@BB@@B@@BBB@BB@B@BBB@D@@BBB@@B@B@@BBB@@BB@B@@A@BB@@BBF@BA@ABABABA@@@@BAB@B@B@@AD@BAB@B@@B@@@B@B@BB@@@BD@D@B@BBFBB@DBB@BBB@@AD@DA@AB@@@BA@ABCD@@AD@BAB@FABAB@B@@@@@@@B@@@B@@DBBBD@@@B@@@@BBB@B@@AAAB@@A@@DABAB@BABAB@@@B@B@@B@@B@@@@B@@@BB@BBB@@B@@@BAB@@@BAA@@AB@@A@@@BB@@@BA@@BABB@@@B@@@D@B@@@B@B@BA@@@@BBBBB@BBBAB@DABB@@@@DBBBDBB@B@@@BAB@@ABA@AB@BABA@ADA@AB@@A@C@CFCDBB@BAB@DBD@@A@@@ABAAA@@@@AA@@@A@ABA@A@A@ABA@@@AB@NA@BB@@@B@B@BA@@BCB@B@B@@@@@@AAC@E@A@@@@@@@EAALKFCDCEGEEC@G@C@GAADC@@BB@AB@B@@@@@@@@@BC@@@@BA@@BCJGEGGICEECEACCC@CDMBG@E@EAG@EAAACAA@ECEACCICCEGACAAA@A@"]],"encodeOffsets":[[[118720,29280]],[[118657,29383]]]}},{"type":"Feature","id":"360102","properties":{"name":"东湖区","cp":[115.889675,28.682988],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@DBBF@BBBBBDBJDFBDF@@B@BCFABABAB@B@BBBDFHDDDJBDDF@FBBBDBB@FBH@F@FAHCN@DDDBDDFFFJDHHHFDI@AB@@A@@D@@A@@@@@@@@@ABAA@@AD@BCHBD@H@D@FFFHCDEDKLBBNBLHJDBBLDDDAFFDBDBB@DDDB@BBB@BAD@DA@@B@B@@@@A@A@@@C@@@ANBF@F@D@@@@ABCBEBE@@@@A@EAA@AAEEACGGGIAACAEACACAEAA@CCECGGACACA@ACACAAA@AEAC@AA@AAAAAADCDEBA@@JB@CCAEA@@CGGI@A@A@C@CBC@A@@BAAA@@@A@@@AA@A@AAAAA@@@AAAC@AA@@AA@AA@@@@@@DCB@B@@@B@BB@BB@@@@A@@A@@@AAD@@@@A@A@@ACAAA@@AAA@ABSG@A@@@@@E@O@@@@@C@@@@@@@A@@@A@@@@@C@@C@@@@@@A@@AA@@@@B@@@@@@@F@@@@C@A@@@@@A@C@@@@@A@A@A@C@E@A@C@A@C@AA@@C@@@@@AA@@@@A@A@A@@@@@AACA@@A@@@EBC@ABOJIBCJ@@@@AB"],"encodeOffsets":[[118633,29374]]}},{"type":"Feature","id":"360121","properties":{"name":"南昌县","cp":[115.942465,28.543781],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@IAG@SAI@GBGDMBGBIAICICEEEEAEAE@GHGFEBE@GBGACEGEE@GDGBIBGBEDEDELAH@J@HBF@JCJABC@CDABAFED@D@HBD@DADADABABCDGDCFCJEBABABCBABC@ABCBE@CBC@C@C@A@CACAAAEEI@@QGEAKGCCCCA@CAAAAC@CDIBCDEBABC@C@AACCCECAC@E@C@@AAAACCAAAACAAACCACACCACAECA@AAEA@@@A@@@@AAAA@ABA@ABABA@@B@@CBA@CBCB@@AAA@A@A@@B@BAB@BABA@@B@D@B@@@@@BCBC@A@A@@BADC@@DBBA@@B@@@BDB@B@DBBB@@@@@@B@@A@A@AAAAGAGAAAA@ABC@AAC@AAAACGCEAGCECG@G@C@IDCBE@GAMCAAAA@@@CACAEEECAC@AAAAAA@CAEAEAECCIGMQCGGGOKMKMGMGMEICMGGGGGECAEEKAIAI@M@K@K@IAICKEKCEEIEECEGGGAI@EBC@EHSLCBE@AA@@CDABOBCBAB@B@BBDABABA@I@GCECEEC@A@EDE@MBCACCAC@AACAIACGG@@GACCCE@EBGJMDO@OBSAGCEIOCIAIBKHQFGLIBA@ADCBELCD@DADAD@D@BC@G@EAE@C@C@CDADAB@F@BBD@DBDA@@AEBC@C@@@G@CBEDADCD@J@RBFADA@ABE@CCCECEECC@CBGBIDGDM@@@C@A@A@@@A@@ABADABCBA@CBCBA@CBABA@@B@@CFEJEFCFE@K@ODODEBA@C@EAEEIGCAAACAA@AAC@AAIAC@@BAACBC@A@AC@A@AAAA@A@C@ABA@CBA@AB@DAB@BAB@BABABCBA@ABC@ABA@C@@@CAA@AC@A@A@C@AACAAAAAAAAC@AAA@CAA@A@A@C@A@ABC@ABA@C@A@A@C@ABAB@BBBBBBB@BBBBDD@B@BBBB@BBB@BADABAB@B@B@BABA@C@A@ABADC@ABA@C@ABA@ABA@@@A@ABA@CAAAA@@B@DA@CB@D@D@@ABC@ABA@C@A@AAAAAAACAAAA@ABAB@BAAAA@AAACCBA@CB@BABAB@B@B@D@B@BAB@BABA@@BCAA@@CAA@A@A@AAAAACAAACAACAAAAACACAAACAAACAACAACCAC@@@@BCLKTKLKHAB@B@D@B@D@DBB@DBDBB@BBD@DBD@D@B@DAD@D@DAD@BADABADAB@BADAD@BAD@H@@GTADCHKJKLMHKHCJ^DNBT@TGTONOPCHIRGVAHBRDVH^FbF\\BX@R@NDHJADADAFCHAD@DABABCBABAD@FDBBDBD@B@DBDBBCBABADAD@DBD@HCH@B@FAHF@ADCBG@@D@@@CA@@@ABA@A@@A@JEBADABADAD@@@@C@@B@@@AG@A@@@@@A@@@@@C@@@@D@B@@@@@B@D@BF@BD@@@@@@B@@@BB@BBBBADB@@@B@@BBA@@@@@@B@BB@A@@@@@@B@@@@B@B@@BB@BB@B@D@BA@@@@@@BABAB@B@@@@AB@B@D@B@B@BA@@@BDAB@@AB@D@F@PFDBD@DABEJABA@AB@FAB@BBD@DABA@A@@@@D@D@B@DD@B@B@BB@D@FA@@B@@AB@@@@@B@@@DA@A@@BAB@@@B@BBB@BB@@@B@@@@DBB@@@B@@@AA@@@@@@@ABA@@@C@@BAB@B@@@DAFB@@BBFBD@@BDD@BBBBBB@DBBBDBBBFDDBHBB@D@@BBB@B@D@B@DDD@@@BD@BBDA@@@B@BBBB@@@@B@BBBBB@@@B@DB@@B@@B@@@BBAH@@BBBBA@@BCD@BCB@@A@GF@@ABAD@H@H@D@FBJCAACGEAAAA@CAC@AA@CACAGAA@ABC@CBA@CDCHABCBA@CFABAB@BAD@@@@@@ADA@@B@@@B@@CB@@C@A@CBGBIAA@A@@@@@A@@@@@GA@B@B@@@@CBFJ@HBDABAB@@@B@BBBBBBBBBBB@B@D@BBF@@BBBBB@@B@BB@B@@BB@@@@@D@BDBHHLDFDD@HBFAHABE@I@QFOFKDMDQAKAKEIEIA@@ABCFCDBBBBBBB@@BBDBFB@BBBDBDB@BDBDHHFDDDB@FBDBDBFBDBBBHJHHBDFFBBB@FBB@@@@@AFAFAD@B@@C@E@E@MA@B@@@D@@@B@B@@A@A@@@CBC@ABA@AAAD@D@DBHBJDDFFPJLHb\\FFFBF@F@FARCHAH@D@DD@BBLBbDHDJ\\ZTPHFF@F@nSHCD@FBHBHFZND@BBDBFDBBD@BABADIBCDAFED@DAD@B@@@@@B@D@DBBBNJBBFHDHBDBDBFFFDDBF@FBHBHBDBFDDFFDDD@LDP@HBHBDBD@F@D@DBBBFDHBLBDBBDBF@DDDDDDD@@B@@@H@REFCDCDE@C@IDOFOBG@EAACGCI@CBABEBCHCJ@JADCJOZm"],"encodeOffsets":[[119094,29562]]}},{"type":"Feature","id":"360103","properties":{"name":"西湖区","cp":[115.91065,28.662901],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@@O@O@GC@@@@@@@@@C@@@@@A@E@@@@@@@A@A@E@O@@@@@A@@@@@BC@A@CBC@C@A@A@C@AA@@A@@@@@A@@@A@@A@@AA@A@C@A@@@A@@@@A@@@A@@BA@A@C@@@A@@@E@@@@@AAA@AA@@A@A@A@@ACEEAA@@A@@A@A@@BC@@@@@@DAGEEBA@G@GDC@CAC@CBABABADCACAA@C@CAAAECC@ABABADABCBC@GBEDCBADBDHLHHFJFHHFFDPNPLDH@TD@FA@@B@@@DBBB@@@@B@B@B@@@@@BB@@@@D@@@BBD@B@D@B@F@D@B@B@B@@@@@D@B@@@@@B@D@@@@@@E@@@@@@@A@@B@@BB@@@@@@@@DD@@@@@B@@@B@@@@@@@D@@@@@P@"],"encodeOffsets":[[118702,29363]]}},{"type":"Feature","id":"360112","properties":{"name":"新建区","cp":[115.820806,28.690788],"childNum":2},"geometry":{"type":"MultiPolygon","coordinates":[["@@BA@@@@DIJAPIBA@SCGOKOMECGEEGEIGGGKACBCCBIBCG@M@QAWE[EaG]CUAQBGHUJQDGPOPMHS@SASCM]DIABA@CBGBC@CACAEAC@C@EA@E@EBEBI@CAECAC@EACACACCACCAAA@AAAA@EEAA@AACCAC@A@E@CBCB@@CDEBCBABABA@CAA@ECIEMIEEEEEAAAED@B@D@BAB@@A@@@@@CD@DABABCAEBCBCDEDC@AAA@@@@ACAA@@@A@@BGB@BA@A@C@A@@AAAAAA@A@@AAA@@AB@@ABA@@BB@D@@@@B@BABAA@BA@@@A@@B@@@@@FABABC@A@@@A@AB@@C@@C@ABCCE@AA@@@A@@@A@AB@@AA@C@C@ABC@A@ABA@A@@BA@BB@BBBFBDBB@@BB@@@@BB@@@@B@DB@@B@BE@@@@F@B@D@DAB@@AAACC@@B@B@B@B@BA@C@@@A@AA@AA@@AEA@A@A@A@A@A@@AC@@A@@@AAAA@@@@@AAAC@@BAB@@@@@@AB@BA@@@@A@C@AAAB@@A@@B@@AB@@A@@AAACCABABA@DF@B@B@@@BAB@@C@A@A@E@EACA@@@A@@@AAAAC@AA@CA@ACA@AA@@@A@A@@@A@A@A@AB@@A@@@CB@@C@A@GBC@@AA@A@A@@BA@@@@@@@@B@@@@@@A@@@BB@@@@@@BB@@A@@@@@@@@@@@AB@@@@@@@@A@@@@B@@A@@@@@@@ABAA@@A@@B@BA@@@@@@B@@@@@@@@A@@@@@DBD@FBDB@@BD@BBF@DDDDJBBBDHFFDFDD@DFDDBD@DAB@DCBADAB@BADADEDCBCBC@E@E@E@@@E@C@EBCDABCF@BAD@F@BBBDF@DCDC@CAAAEBK@E@A@A@@@A@@@@@@@@@@@@A@@@@@A@@@@A@@@@@@@@@A@@A@@@@A@@@@AA@@@@@@@@AA@@@@@@@@@CC@@@@@@AA@A@@A@@@@A@@@@@@@A@@@@@@@@@@@A@@@@@@@@@@A@@A@@@@@@@@@A@@@@@@@@@@@@@@@A@@B@@A@@@@@@@@AEEAC@CAE@C@E@CBCBCBCAAA@AACCCACCCCCC@E@CBCBEBCBED@@@@@@@@A@@@@@@@@@@@@A@@@@@@@@@@@@A@@@@@@@@@@@@@@@@@@@A@@@@@A@@@@AA@@@@@@@@@@A@@@@A@@@@@@B@@@@@@A@@@A@@B@@@@@@A@@@@@@B@@@@@@@@@@@B@@B@@@A@@@@@@@@@@@@@@@BB@@@B@@@B@@@B@@@B@@@@@@@BB@@@@@@B@@@@B@@@@@@@@B@@@@@@@@@B@@@@@BBBDDBBD@D@D@D@D@BBDB@DBBBD@BBB@F@D@D@JAD@@ADADADADCBABEDA@ABBDDBDDBBBBBBBDBB@@@B@@@@@@@@@@@@@B@@A@@@@B@@A@@B@@@@@@@@@@@B@@@@@B@@@@@B@@@@@@@BB@@@@@@@@@A@@B@@@@@@@@@@@@@@@B@@@@@@@@@@@BA@@@@@@@B@@@@@@@@B@@@@@@@@@@@B@@@@@@@@@B@@@@@@AB@@@@@@@B@@@@@@AB@@@@@@@B@@@@@B@@@@@B@@@@A@@B@@@@@@@BA@@@@B@@@B@@@B@@@B@B@@@B@@@@@@@@@@@@BB@@@@@@B@@@@@BB@@@@B@@@@@@B@@@@B@@@@@@@@BB@@@@@@@BB@@@@@@@@@@BB@@@@@@@@@@@B@@@@B@@@@@@@AB@@@@@@B@@@@@@@@@B@@B@@B@@@B@@@@@@BB@@@@@@@@@B@@B@@B@@@B@@@BB@@@@@@B@@BB@@@B@@@BB@@@@@@B@@@@B@@@@B@@@@@@@@@@@@B@@@@@BCDA@CBCBAD@B@DAB@D@DBBBDBBDAD@DABBDBDABDAD@BAD@BAD@DABAD@D@D@B@D@DBB@D@DAD@DAB@DAB@DADABADAD@D@B@DDBBBD@D@FBB@D@D@FBD@BBDBBDBD@BCBCBAB@D@B@B@D@BCDGDCBCBAAACCAAACAC@A@A@@B@BAB@@@B@BBDCH@BABB@@B@@AD@BB@B@B@B@BB@@@FB@@@@DA@@@ABA@@@B@@@BBF@F@F@DDDDDDBH@B@B@DBBB@@@@BBB@B@@BB@BDDFB@B@BB@DDB@@BBD@DBDBBBDBBFDHHDBBBHDDBB@HBD@D@BBDB@D@D@F@D@BBD@F@DBDBBFDNJ@@D@DBH@DABADCB@B@BBB@B@@@@@@A@@B@@@BB@@B@B@B@CFABCB@BABBB@B@@@B@B@@ABAB@@A@@B@B@@@@BB@@@@B@@@BBBBBDBBDBB@B@BBB@DAB@BA@@@@AAC@FEBADABCD@@@B@DAHA@@B@@@@BB@BBBB@@@BB@B@@@@@BBBD@BB@@@DA@ABBD@FFFDFBB@HIDOAMHIZG\\IPCPB@@@@B@@@@@DBLHBRJRJJ@J@L@TCRKLEDSLCBABCFA@AF@BBDDFFHDFDDDDF@FBFAD@FCFCDADADAJGDCDCDA@CBA@CAECEACBCBABCBACG@CBADABADAFCBAHGBCBABA@CAA@CBCF@FADAB@DB@BBDD@D@DAFCDABABCBCBABADAD@BABC@EAC@E@AD@DBBDBB@@BE@@@@@@B@@AJ@@@"],["@@@E@@BCB@@@@AB@@@@A@@@@BA@@@@@A@@@@BC@@@A@@BA@@@@@A@@@AB@@@@A@@@@@A@@@ABA@AB@@@@A@@@A@A@@@@@A@@@AAA@@@@@@@A@@A@@A@@@@@AAA@@@AA@@AA@@A@@@AA@@@@A@@@@AA@@@@@A@@@@@A@@@A@@@@BGHI@EBA@AAAAC@A@ABC@@@ABGAC@E@CAE@GBC@AAI@G@EAAAIACCAGCMEEAC@GCCA@AIGAAAAEGACEGAEAACICEAA@CACAGBIA@A@A@A@AAA@AA@@@@@ACACC@A@@@AAAAC@@AA@@B@AA@@@@@@@@AA@@@A@A@@B@@A@@BA@@@@@A@A@A@AAACAAAA@@BA@A@CBA@CAA@CAA@A@@@ECCC@AYCSCYnIPCDIBI@GDADAFAB@DDJDHBB@FAHEPCP@J@DCFCDEDQFG@@@A@@@CCCCCC@CAEACCAKAGAECAACAC@E@C@CAGAGAO@KCC@CCEECCAEACAGAG@EAECCEEAEACACCGEGAAMIAACAC@A@@@@@A@C@CBC@EFCBADCJABABC@AAECCAAAC@YMGEGAEAC@GDmTE@E@GESO[YCICGAaAK@ACCC@G@GBQDEBE@E@EAEEa[KGOIEECCAIAG@C@CBCA@CC@CAAACECBECCKCAAICKGMA@F@@@@@@@B@FBD@B@@@@A@A@A@AD@@ABA@A@@@A@@AMBA@@B@@AB@B@B@BAB@B@B@@BB@@@@BBAB@B@@@BC@CAA@ABA@CAED@D@D@BA@@BCB@BABABA@@BAB@BA@AB@@A@A@CAAACA@@@@AACBA@ABAAA@AAAA@@@@ABA@A@@@A@C@@@A@@@A@BA@AB@@A@@AA@@B@@@BA@@BB@A@@BA@A@@@AA@AAA@@A@@@A@@A@@@@AA@A@@@A@ABABA@ABCB@@@BA@BB@BA@A@AA@@@@@A@@ACAA@CA@@@A@@@@@@@A@A@ABEBA@ABC@@BC@AD@BAB@@A@@BCBC@@BA@AAA@CAAD@D@B@@@BBDDB@BBB@BBB@@B@@B@@@@B@AB@B@@B@@@@B@@BBABA@A@A@@@AA@@EBAAIKAACACAEAEAAD@DBH@D@B@D@DC@CCAACEACAA@@AAA@CAABAD@B@@@D@BBB@B@@@B@DBB@BB@B@@B@BBB@B@@@B@@BDBBDF@B@@@D@@AB@BA@@@A@A@@BA@@@@B@A@@B@AD@@@ABABA@@DB@@@@@@B@@@@@@BA@@@@@B@@@@DA@@B@@@@B@@@@A@C@@B@@B@BBB@@@@@B@BB@@A@A@ABCBDBDBFDFBBBDFBBD@BBB@B@DADAFAB@B@B@B@BAD@B@B@B@BB@@DB@@BBB@B@@@DAB@D@DBDBFBB@DADCBC@ABAB@D@DBBBB@FAD@DADBBAF@D@BDHFBFDDFBL@HCRCLCJBHFBJCHAL@PBLBL@HLJLFHHNRbDJBFDHFFHHHBHBHDFDDFBFBFDH@HDFDFDJB@@DADAB@@AB@BAA@BAB@B@B@@AD@@@F@B@BB@@BD@B@BBB@@BBBCB@@BB@BBDB@@@BBDD@BDBB@@@@BBD@BB@DAD@BABA@@BC@@FBDBBBDBJ@B@B@B@DDFBDBF@BBD@@@@@BBD@D@BABBB@B@FBF@@C@A@A@AAABA@ADCBAB@@@B@B@@@B@@@BBDFBFDB@BD@@B@BBD@@@DB@BBDBBBBDBD@BB@@@BAAA@@BA@AD@B@D@@@@A@@@@A@A@@A@A@C@E@A@@PIFKBBBBDBD@B@@@BD@@@B@@@BB@@@J@@BB@@BBBBBBBDB@BB@AD@B@@@B@B@@@@@BHBB@@A@A@@@A@AAA@A@@D@BBHDDDFDJHFBDBBBB@DAD@B@DAB@B@@BBA@@F@BAD@B@@@DAB@B@@@B@@@DBDBBH@BB@fCjJIA@CCYSEE@@EECC@@@@@C@@CC@A@@ECA@@A@AAAAE@A@@BA@AHEHEBABCFGFIFGDEDC@A@ADAFGBADCDAJEFADAFAHAFAF@PAB@R@D@HAH@B@BAB@BABABCBABAFC@A@A@A@C@E@A@ADC@@@A@A@AEK@A@A@EBIBIBA@@@@B@@@D@DBBBBBDB@BBDBBBBDBB@B@DB@AFAB@B@DBFDB@B@B@DA@@@@B@DDBBBFBHBHBD@D@J@B@B@DCJ@BAD@F@JAF@BCFCJAF@BCFAFADAHAHAB@D@D@F@DBDBJBBFNBBBBBBBBDBDDHBHDD@D@D@B@@@FAn]DCj_FCf]\\SlFH@DB"]],"encodeOffsets":[[[118633,29374]],[[119195,29751]]]}},{"type":"Feature","id":"360124","properties":{"name":"进贤县","cp":[116.267671,28.365681],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@AICGAG@EBCDEFGDGBK@K@EAGACBA@@CABAB@B@BAB@B@B@B@@@AABCBAAA@ABAAAAACAA@BCB@BA@A@A@A@AAG@AC@A@AA@ABCBAAAC@@ABE@AAAA@ACFABA@@AAAAAAAAABC@CAECCCC@AAMICACCACAACAIKECEE@CEGEGAECGCECECEAC@I@EBGBIBI@IAEAEAECECGCEGCEAEAEEGEAEAGAGG]CKCG@ECEGEGCGBI@KBKAK@K@I@K@GAGAGAEAK@ICKCIEGI@I@MEIEIGGEAC@EBCNBJAHAHAFEFGBGDGDGFEFEDGBG@ICECCCAKBK@E@EEGE@EBEBCDCBCBOEOCKCGCKGKCGEIEIEIEGGCCAG@M@G@IACCE@@@A@C@C@A@CACAA@@EBAB@B@BADABCBEBIREFIDG@OAUBKFQLGHAFBFBH@LGRILKFOFKBK@OHIDCBBBABADAB@DABABCBCBC@C@ABA@ABABAB@B@BA@@H@F@B@FADAD@@@B@@@B@B@D@@CNCHAJAH@DDDFFFDDD@DAF@BCBEBQAI@C@CDCBAF@D@H@@@DADBF@@CBCAC@AAE@A@CBCB@D@D@DBF@F@HADC@C@CBCBC@KDAFCD@BABKJEHGRALBJDJJPDFBHAT@PCPINAH@FDFDDHB@@HHBDBJBD@BBDDDDBNAF@FCB@D@FFFDHDJ@B@BABAAC@A@ABADAPABADC@@BBF@DATKFGD@FAJ@HBHHDFFFFJDFFLDLBJ@J@L@L@NBJBJFLBFFDHHHHNHJDNFNHNHNLPLHHDHNRJHDDBFBFBF@DBBBBBBD@DBFFBFBD@D@@BBBBNDHBF@DAJCD@H@H@FDHDFBHDBDBB@BBD@BAD@BBBBBBHBHBB@B@B@BA@@@@@@@AACAA@A@AC@@A@@@ABCA@@CDAB@@@B@BADAD@@@@A@C@A@@@ABABA@ABA@@@@B@BBB@BA@AD@DAB@DA@@@ABAB@BAB@BBBBB@@@@@B@@FBBBB@FDDBDBBDBDDDBBDBBBBBDDBBBB@@@D@FBDFDDDBD@B@DADABCFADCJ@DBDBBDBB@DDDDLHFBRHDBFDHDFDHDFDFDHBD@HDHBD@DAB@@G@E@CB@@ABAB@BABADB@@BB@@@BB@@@D@@BB@B@@@BBBB@BAB@B@BA@@BA@H@H@D@BA@A@AACBEDGHGBCBCBCFCJCH@JCN@LEH@HCFCLGFEDCLKBA@EBEAE@CCCAC@@AC@CBA@@@@@ABA@AA@@AAAAEACAA@ABA@A@AB@@@BADB@@B@B@@ABA@A@C@C@EBA@CBAAAAEAACEACAA@A@C@E@ABADCBCDCFCDABA@@DEBABCDABABC@ABMDMJQHQJOLKHOJIFEJIPIHGJGJKLGHGHGFKJGFEHEBCDCBE"],"encodeOffsets":[[119353,29181]]}},{"type":"Feature","id":"360123","properties":{"name":"安义县","cp":[115.553109,28.841334],"childNum":1},"geometry":{"type":"Polygon","coordinates":["@@A@BC@A@@CCB@@@@A@A@@@@B@B@@@BAB@@AB@@@@A@@A@@@@@CBC@A@@@A@A@A@@@A@C@EBAA@@@@@@AA@CAAAA@ABE@CDA@ADADABAHCBCBABEDEBCAACBCBC@AACA@@@AAA@CACAA@@A@@@@BC@@A@@@C@@@CB@BAB@B@@@@AAAAA@@AA@A@A@A@@@C@A@AB@BA@@DA@@BA@@BA@CAAAAC@AAA@A@A@@@EB@@AB@@C@A@AAAA@@AF@@A@ABA@@BA@@@A@CAAA@A@@AC@@A@@@@@@@@B@@@@@FBB@@BBBB@BABEBGDCB@@A@A@@@A@AB@@AFA@@@@BC@ABA@C@KC@@@A@A@A@CAA@@B@BA@@DA@@B@@A@@AA@A@@@ABA@A@@CGACE@EBCB@@ABA@@AA@@@A@@CAA@@@A@@@@D@@@@@@@@A@@@@AAA@@@A@C@AACCAACAECGIEKAAA@A@@B@@AA@@@A@@@@@A@AA@@@@AA@@@AA@AA@A@A@@B@@@BA@@@@B@B@@@@@B@@@B@@B@B@@B@@@@B@ABBB@@@B@@@B@@B@BB@AB@BBAF@B@@BBBB@B@B@B@@ABABE@AAC@A@AA@A@C@C@CCE@CAE@CAKGQGOIOKOEK@GNIDCLOBKAM@@AAA@@@AA@ABA@C@@BABE@@AA@AAA@AC@A@@@@AAAAA@@AA@A@@AAAAEA@@AC@@BA@A@A@ABA@C@A@A@C@A@@MIECAAAC@C@EAC@A@C@E@C@CCAAAC@C@GAA@CAGCAACAGGECAAACAAAC@CAC@AA@CCA@@A@AEACC@AAA@@@AAA@A@@A@AA@C@A@AAGCCCCCCE@E@E@AA@@A@@@B@BA@@B@@C@@A@@E@@AAA@A@A@A@@ABC@@@AA@BA@ADGAC@A@A@@BAA@@AA@@@A@ECBCCAA@A@sD@@@@BB@B@B@@ABBD@@@B@@ADCB@@GJA@@@B@BA@@@AB@@BB@@B@@@B@B@B@@@@@D@@D@B@@@@@ABA@AB@@@@@B@BBB@B@@C@@@@BB@B@B@B@@@B@@B@BBBBBD@@@B@BA@AB@BBB@@@BB@DB@B@@@BB@@BB@BB@BBBB@@BB@@BB@@A@@BA@AD@@@@ABCD@@@@B@@@BBAB@@@@@BB@@@@@CB@@B@B@@@B@@@B@DBADABABEDABAD@DFFBD@BBH@L@F@B@@BD@B@DBD@B@DBB@DBBBBBBBDBBBB@DBB@D@B@B@D@B@D@BADABCBAB@B@DAB@DA@AB@D@BBDBB@BBDBBBBDBBB@BBD@BBBBD@BD@BBABABC@ABC@ABABC@CBC@AAC@C@C@A@C@ABCBABABCBABABC@A@EAEG@ACAAAEAMB@@CBKDE@E@E@@AA@AAAAAA@ACAA@ABABC@ABAAAAAA@A@A@AACA@AAA@CAA@ABCBABCFAJC@EAC@EDCBC@DF@D@DEHCH@FCFABCD@DJ@B@BDAFGDAD@DDDBBDADAFBBBD@D@CEAAACBCD@DFDFDDDF@DBFDDABE@CBBDD@F@D@BDABAFFDLBF@JBBB@BBDBHADCHBFBDBB@DDDB@DDAFAD@DBDBFDFBFBF@BBA@@B@BA@@FEFE@AB@BABCB@BBBBDFDBB@D@DBBBBB@B@D@B@DBB@DBBBBDBBBBBBBBDDBBD@B@BADAB@BADABAB@D@BAD@BABAD@BABADBBBB@D@B@B@D@BABABCBABE@A@A@AB@@BD@B@BABAFCDADADABAB@@@@@@@@AB@@@@@@@@@@@B@BA@@@@@@B@@BD@BBDB@@BAB@BCDABCBABAD@D@DCDCDCBAB@D@@AF@@CFGFAFCDCJ@BADGB@BC@A@AF@DCDCHCDAFADBDDB@@@@@B@@B@@@@@BB@@@@@B@@A@@BB@@@@@@@@@@BB@A@@B@@B@@@@A@@@@B@@@@@B@@@@@@@@A@@@@@@B@@@@@@@@@@B@B@@@B@@@@B@B@D@AD@BAB@@AB@B@@@B@B@B@BB@@B@BB@@BB@BBB@B@BB@BB@BBB@B@`JRFJ@HAH@HCHEFEFCHEHEPQFEFIHGFEHGHELCJ@N@LEHALBRAHAFCBA@@DCBA@@C@BG@E@@DA@@@ADAB@DAF@@@@BB@@@B@B@B@BAB@BABA@@B@B@BC@@@@BA@AB@@@@@BB@@@B@@BB@B@@@@DBBBB@D@@@BA@@B@@@BAB@B@@@@@@BDBB@@@@B@@@@D@@AF@B@@AB@@A@A@@BAB@B@B@BBB@BBB@BB@B@B@@@@@BBF@@@@BBB@@BD@@@BA@A@A@A@A@@@@AA@A@@@@B@BA@@@CAA@@@AEA@@AAA@EBEA@@CAA@CC@@@AC@@@@CACBA@@BCBA@@B@D@@AB@H@DGBAB@H@BBXADAB@FCD@FBF@DAD@DCHABAD@BBD@@BBBBBBD@L@DBBD@B@FAD@BADA@A@ABC@EBEBABAFCFCBABAHI@ABE@A@C@ABCBABABAB@"],"encodeOffsets":[[118539,29587]]}}],"UTF8Encoding":true});}));
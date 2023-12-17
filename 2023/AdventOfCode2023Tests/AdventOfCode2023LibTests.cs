using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AdventOfCode2023;

namespace AdventOfCode2023Tests;

[TestClass]
public class AdventOfCode2023LibTests
{
    #region Day01

    private const string inputDay01_1 = "1abc2\r\npqr3stu8vwx\r\na1b2c3d4e5f\r\ntreb7uchet";
    private const string inputDay01_2 = "two1nine\r\neightwothree\r\nabcone2threexyz\r\nxtwone3four\r\n4nineeightseven2\r\nzoneight234\r\n7pqrstsixteen";
    private const string inputDay01_Final = @"sixsrvldfour4seven
53hvhgchljnlxqjsgrhxgf1zfoureightmlhvvv
fives2dznl
twocrqvjsix5threethree
gtjtwonefourone6fouronefccmnpbpeightnine
seventdtrcseveneightsevencgjgjxfpmfsix8twones
fourthreeseven1grvhrjxklh3ninetwothree
fourninethrnnth8
two2hnxcfivejrdjxtb
bssbrgcx86vsmqstrxsjbjeightqzhbzxqg5
rsevenbqjfxh23rzdgcmdleightsixknpfs
jprxbcghdgxhk9x
8czzpmvgmlchnkf
vdrtteight85hlkninehgnblqnsdnineeight
fivetwohlxdql43kfzzbhtncg
lmhtwoneghgtl2
drtfsfhtbgfourpfpcznzrsix33
pptqkrdbeighteightsixdlsixkrlhr2
57threetwo
qoneight367gqbpbtbffivetlhrdjgnml2d
ninevdnzxsxone3
3threeqzrmfndfiveeight4
rmthreethreefourtwotkpncxpmctkxjhzxg5
nsfrpl6lkqrrmlxhrxmngzjtzbpsjgeight
9twobfknine57sixfour7
7one83sixthreecllxjnphb
82nhxcjnck1
5zrffive
bgdzqqpninefourjhtcjfjmxrmqhgz7fxnjrjfivetlpbddcsfs
xmbgqfhxx1sevenkfnqztfourzbngv
6onethree
1przkgcft77xblxkxm
hnjslmc96
fourktlnine59
7twoxthree
9twofiveonetwo5bnl
6cbzmrg1three7
fbndztsthreefourthreefgj1eightrffdbpsn
4zpqnskhnqjbjlhbbsxsmk
seventhree1fourbvnbbsbkl5
five42jkbzqcnblr
357
543cshpxrfnnhonetkbhxtmlgczdndqjscb
2mpftseven
44five8nineeight
rmgrljrljb8hxxfmdpbbvmblltxfive6mdsmm7mmpk
nprsix6
five4vkqrsixmjkjps
kfivebrlzvc1twoseveneight
lqnjsixtwo7fourbmbxnr9dqmpbbfkfive
1ccsvvrrvjseight9nzgnldhzndpvdzcncl
zdzlsix9rjvninehsix4
fsevenfour8four6three
eightrmvsq65mpvffkkhxc6seveneight
sixrmgchvfttpbsncc5hnine
147
57gsdhqjbrfsskhmtcbszmjmhrxg7
sevenfive31twomhkhttdprdnzlng7three
3spgnkpeighttwotwo4
psxlxdjrtmgpveightxjkxhmbeightsix2
five53vgqcfmgqlm5dkchcmfkclpfxntbf
76sixmgqgftzfive4nfsqhkqvptnnshqlhd
sevensixsevenone7xbsxvdpdtc
nine3sixfourtwo6mpmpjb
eight4sevensixfour7dtgrvpq
1sixnceight1bg
79xfftvpvfour
noneight3
twoxdhkkgxhvz5three9seven8hszqdvnhr
kbpc9kqvhonelljprfs4pzcnpfrdssfivetwo
four4eightseven
5three95cqs65nine3
72sevenrkcqmqbscp9kzjxrg8d6
5rjbzpghninexfzvjpqmt9eight
jfjrvzcjkrkd1eight
six4ccvbclxkkntzmgthreercsjbznfive
xkqdtghlshthreeninefive53three
one3fgcsrxk1
1foursevenmvmzpvkqseven351
858qqbkgjxqfive
fkpd4three8sixlkttgnfzc
btpmrzqmsevennine3f6
61nine
fourone7fsfxfrlqzvbqjpccfour
five85sseven7jxlpl
kzgszphcpfoursevenlzlkqmjndz4ninelnine
4eightld
five8dqzlzfnine
6zjsqxqnineplbqhxltmffour
1fivebfoursrdcfive
8678fourgzdhrtrtwothree
847
fiveeightdseven5fivefivecbdrrbnng
5qddhnzxlhqeight2sevenln8nine9
13kxvqlvt7xvcksdthreekfqc
1threehqshd9two19
twogcphmsspeight7
1pnktcbbpkmeight42hcgfoursix
nineninepdxqg4xspkqjneightchqxptninegcckrbmsvk
fnine5ninex1eightgdhpkngmgq
jlgvcn73three
twoljsp5
xlf52twovcnnjglhmm
lmonesix1kfhbpdntpthjkl
89six6threegmfqlone
ninefbdvbhrgfivesevenzsjlt5tqkzfxb9
pvfoursixgdtvxxvlnx8kgsj
9fpjsnheightfivermpxrkddczvzqbdbs
92zhksstbzr
fvxeightwoddrhpfsevenmlkp178
2ntqvj42eight6
46xthree26snkhxmmzknhrvsfrprch
lvcfiveseven3plzlsvmm
three69
scrkglnine1
fivemlvcpxfcggllpnpsdjmnhhkfkbtmcfone2
7tseveneightnmjqbsfgh
onegbdpmtwo39nvbdl2
532rg
3cpjksevenonejjndff9six
4nbtbrmtxmpcnvkjsgseven
2brfkknktcz
ghtshqhnmvmgdps6rclhhsix
eightj4hnnsfssqqmfourgdrmgcljdnslrhmkc
seveneight5pdzgpjvzlsxkjpflkjbzqhrfdlbskfbnbkcpl
six5gqjlsevenfnffpl2hrdrvrdthreeb
137nineone81one
gnrxrnqjdtxvcbggcmcfshz8rrkfd
nrlccp4szxqgljj31
622kvttthree3jfd
8zqgbdc
rmczlxrvjpp79sevenonefourmmjvgthree
3fournine185sevenrgtrrpgjf
five282six
three7xcqlxd16sixktfmxslk
6vrzsmsv8
4twodqjxsbklhjtfthree
3dmxljghfourzkvxq3
4lveighteight51tfgbbfour
csfkthreesixxcfpdone3tvscpp8three
vhmkkks6glrlpv
eighthnine1rsmbpndnqqgds
7tnbhktwofive84seven
3kjpxgrlmstnxxdnqgpgjhcttlmnineninesix5
2eight4264
twoqmvnmxstnqfour8d621kxktzk
pdksthree5gzpvlmjmfourtwocfbsthree
rtvtffd6fivefive
onemxrpmlxsbd9drnsfive3
zfjqcthreesixoned1sixsx
flsevenvqctldf6
1seventwoeight6
xxktlvdcdtstsqjmd47onell5
6tbvxcgddrfjnhgntrthreegx4
rfxjvdllvzv2dshhdtjvbxvsqmq4ninegp
five7bjzhkmmfnhcmnfljlhb6bptflhrrvgfour
ltzlonenine5six
nineeight49
fqcdtgtb9sevenrnsgx4
eightlfdmv5threehrrkvhzhhxmzprz
2dglljrllsix
sevensixxnlb473twotwopgjxgp
5sevenrkhk
9eight3
7one5four
lh5jzqxeight84
385nslvbjqvkxvvcprqghxccv87fpmqfhnlv
ngsjdpvv72sixmbtr
xvslr642
mrjhmtnhx2
gsrbhmh5fiveoneqhhmsmkrbc3sixtwoeight
mnxvtn3vtqhxsrfivefive57qrmhshkk
9vkghgztxdzcvl7dlthreefmklvsmhxnqrtzzsvvq
djclthdptrk8fournineqvnrrlbjjhtwoeight
79pnt9one9
mlcxcrjzpvlkkdpmmsevenone6npd
fivefiveninezhppshtks1kqtkss
7nine46cxzcjhbnbg5
fourqhbr5cqbdmvps
pqvzfrt7ftplx
265pninenine5twofive
four41
1fdgcmbc1onepcktj3seven
5twob
two1sixc7znfhkhzgzzjzf3xdbqtdspv
vqkg7sixrntjjzc
7one9zdnnqtbbq4gkkkdskbtlqspsmx1pphnh
xgsix2hltpnqxktwo
gmhmskd37nqk7q8
onezxllhcpjfkeightsjvvpmcztdndf8seven
ninenmrljg6fivegmtzhflztxn
nmzqxlx387eightczpsgxskfzklk9
1fournine7cgtmr2lsvljtp2
98lzz1sixfour1three6
one8ninetwo
4xcrhxlvsr7
8two2four
ninefninefour5qlxbmk51
hhlflbbmbd29jrjrbx5879
six3djmgs
cfivevgzckfqcg6ninesixfvlkpm
449honexjqtrxveight3nzzx
threetwo22
d6seventhreeeight949
nllbxt3qspvt6sixgglvfcfivetwo
jhfrfgjjtsseveneight76
gjninestxljz88six2
5rsqhsx9rnd
7three72sixjkxlnpt
dhkfvps9
onefive7qdvbqjxzk
7sevenldcfd7
twoeightpjpkcjvvbfseven6
six1eight9five29
hgdztcbpx4sixseven1fklt8six
6six7kjlpmld1
twolpxfhllfllkcksvsllbtvjsll2bjq
2nine7nine79fourfourbtqd
tjfsmthreeoneninendd6two
2five1
1seven1jrgtkcfsjfbfrmsevenfourlvbgbknn
79twolthjsjnbrthreerdmbk3
sevennine6432
1hjtcnjztkvjspr7
seven84dlbb1
two78threevdhgqfzt
7bmln29onezlxtzthj7fzpvnxllz
nldvscqn9hfnthreesevenonetwoflbrdnhq
sixpkx7eight1ctbhdf34
rprprpmfour3fivevxqrqrqp4tghglvssfive
gpxjnsrsonezn1bht
2three4ninebnfzzxzl8seven
two23one2
9sevennmxmxvzcpt3hgsprhmvtxbqvbn2three
69threeonervrxqdfive
scjjqgrbnnsztvmbtninethree74two2
one7nkbn6nine
nlmdfshone2eight11sqhsftrg
fxt4twofive3sevensevenxq
three6zfzpdmrpbr9289vszpcqkq
8threebqzbpz3
plpnsfour6
1twonetdm
oneseventwo4x
fourhmprhkfgdkgqznineeighteight2
984mrrqjhzc3dsqpjvrpctvbtk
onenjdmrjfdjznrffive73fivechpxdpnqbnpq
4mhjzvbgnxpq1jfllblcjkbxzrt
threeblztlfgltlznxv9cqsjfnmgftnmscjmxpmfkleight
jtvjjrjnf2two
8oneseven3djtdzseven3
bctvlxxxgtp4
onenrncdseven2foursixone
sevenseven1
cfhszdltcqkllpqbfive6sevenqjqphqkhhjsixbvblzhgfp
dpzbcnbdzzninev6eightlk
eightjznzkdg53fourninebsfdzqpsix
four4s88fdxtnt3six
nine33six15five6
eight3five26jdrrmvnzgxm
zjzpg4onesixseven
99fourfourtwo
xlxmvkdkvrfrddhvgmhrqllvcpsnine2
fourfour1xfpdnfqvcklf
ninethree7one2czbtzzfkz
two41hgvsfzmtcz13
sevenfour2sixq
seventdnjmqhbmm3zgffshmjlzcjcvbl7mzc
khthzgjkzdkgjzxlkrvd4fivezq5
fiveseven4onefourxtrfournine
9onexh
83ninet3drmkrtpdc6pmdrvdbx4
twofvxngqdhlpstlhfhxonegrrzfbsv7
seven3fivethreepqzfl7
56two229
djrthreethree3seven4zxlfntgssq
three3mdkbtxkkfour2gtpgcktqflrfs
711q3ninevbsg2
ninethreenfone4eightseven
onexfxnine64fivefour
foursqctmzlh64eight
8one4mslnine65fnr
9mbgn42bfhbfive79
75kdhhfllf1onesevenssvztltg24
jxrpsflt52jz246five
dlvhq4pzxcstjtxq9
lgnxqnhjsbsixpm24two
3sevenfiveltdmfzlq842four
threetwosix39foursixthreethree
nine12bkhqklpfour3
73534two1
nhkbzfmgdhjjhggfivebncmnbskphsixnine2five
xxzvlxmdtwo8threerbtwo1eight
5bvzltnmqgnfqvqk3fivefhhhhnb
qthree1fivettjdpgnmkcfive
tknsqnjjczfbgshtvpdchpb6fngjztk77four
1five2seven1rsqfsrxfcmnxtqj7nxzcc
lcvzgqpmlgonefourseventwosixnine8
ssqcjzpjb5five5two
seven7nrgglcjfour3two4
five4fivexnbnoneninengqngmg
8fiveltmhtwo
jzmqtqbzh1
1fourthree
2eightfoureight2
7nzkfvzfivemchbf
7four2tpfvmjgdseven7
1dzfpxmpxjscclshsixknfmgrpvptdf
rm4618bkgpgmrhdldbftqzssbzsqxsix
fivemmfxdgqpj7sevensh1nine
qgqxznine19sixeightone
one7sevencnpdqmv
vgm8four5ccrcnbddv2
28gxkg245hpmd
ngvvdk41eighttwoseven
1nine54
onehcvdnt7twonflthree
5nineseven
8x
fiveznsz56
mplrzchnhjgxfmqbpfdm7kzrfour4threehjt2
gdvjfqsqmnine67jlh9
4tphmcfm33sixvgonefour
61fourthree7ninethree
five4qsk42sixmxdrqcndcmvxcfqv
rkrstzqone3bjjpgfrgg4859
2oneqlsmvzznsxninefivesixksshvprpfive
6fouroneoneqffour6jpfqpvcmx
xshcfrdxnlv125nineone45
jqdvfiveglxjpbvzch9
6jqmjmqznqmxkztdgzb
tzjfdrzvzfivejsv49eightwozmf
rslmsmj4vnq71eightfive
vbmbfkfour26sz9
6two769hffxnbnineeightnine
9five3hqjdvxlmvvckndzhsix
jtknzpnbqpfgtdbnxkbthsix78
fivethreerht48llrprvphts9cd
eight19
sixone66six1seven
fsgtskzsk9eight6
2gb
onecone79g8
vgfqd49mk26qmxhqb
lclctndpsffrbdmztb8
1seven4
thxj66ffbzzkz6twolzsbqseven
2lrgrrhceight
332three9
dmtwonegppvjcmj2sqplmshfsd69
fqdmgxtwotmzrb549six7seven
87kkcbqvfftwomxsixsevenfrhlthree
82l15vjddqclrtttsm
2gjb3qhxvdrblq1
three4xvqb9nineone1fxsvj
921
4xzzdgzpklltssh95two
twoonejsmrddbtcng8zbhfbqvblbkmcpxst
8five949
pmpv69fourddfxzrvphdsxz6
seven6cnkkgphkdmvnxnxfvkfcmgthree
98three
threert9rfsix244
18jnzxfivefour1sixthreefjngk
543vlxckcffkj
crxdmtzone1
t99vqbpprvvzq3fz
1mfourdvpfour5dzzdnjbdfxchkgpbnlss
five11six5
9bbvmmxkfzldhjfghnlsevenfour3slnp
twokglseven1qqhsp57clctgc
kmtrnineseven6one2
four1rg8five
threefour5sixsix
mdvrfdcxndd1
hqtsplgzqbrxbbstwolzrjcnqf3threeq
drhoneight7bnjh3fiveninejlqlljd
fivefqqfcmzdfour1
94thphvvkmkhpdnqsrh
bsqhfjk3zxzhtqfncc7lcbzpgx
threezzjnlpgxhsfxmjl9588
fourfourn279six
fivevxzjpss5eight
5fourc8fivenine9hmdgxjeight
3threeninexjbzmsgrhkzxscfhddhsixtwohcgjfdszpxjsp
sixknhkfsmqvvvone9jhfxjpr
8bxgmbbdmrvpjfxbzd
1dpxrdfvp3two8one8one
threefbvbfkk3scsbr
gvmrjgjkdppdc9one
133gglhlfprmtnqb5four
vtzddchxktgsshpztmpxxvrhsjq1fkstwo
8one5krgr55
twofive8nine5
pnjpkthree47eightjbsdz72
sixonefhltgkbbbt8eightthreefour3
72gbr5
38mqgkbbkhbksqxfive61
8ckhzckrkq88threessqqcpbnonejtxkxbbfive
5threetwocrfsxsnf643
9tlgcxkr
threehbmttm59sevenhfourhpqrjqj
dfbqxtzkkpfseven42sevenseventwo
86eightfvxgfjzrf
vxfl4
three4bshflzvvdnbeightfqdlqnvlrkdxrtnpjcqn
5sevenpxdrhmjbgdgpnseven
2two4
9xxnhc8vqmrnffmg3
97kqfonefhhc4
8fiveseven9
nine6eight
52five3one2fkmnk
kfdxhkninestttsmtkmkhxbhhxlbxsix3pvdqd1
fourninedhsvphbmhccjcktqsnthree8
fivefive35three5four33
4seven7seventhree6
vfkjpfxltm5xcq5nine825
52onegczcpghmzxvgjglbpjrtseven
5zzlmvl
kmsnldpssvdfive519kvmlnthree7
lpkshkvrrl124dpgplnine88
644seven9qdpbpxdlxf
7jqc
cbhpmvs7
two7twoonebdmzftjjxrfmsix
5mxxmdzdqdsixfourone
3g6
fglrhqsseventhreefivedpq4
fivefiveglddjbfbk3two51eight
7eightfjqqhljpxgvlghsc9lfqctddsoneninetwo
mllcz8vczcgrbdn41qfglhzsqk
gxstgzqfrfourgkxvnkpgckhnxj7seven
93sevenjzvxc73
63nine135gqdhbnine
ltcgbbxftssixdgtxdpp1kzbhvqt
2z3seven1
4two9qnfrvcbonesixzfr5
twojhlt32
8one2eight
cdjdb4vcvg98
three9nc
qmfjqnsbthree97
fivenine5one
glnine55twoseven
three7k2
437five
svzrgbljxdstwo9six6four
383zseven2eight3xvqvp
6fivegnglqj8tfkfgxkm573seven
twosixltnpgkkr3
7sevenmphlgrdz72j
5nine24
hq9b4fourbgtjjgmzfj6
1sevenczhtpmvmstvvgrbrhptxtlneighttwo4
mbhfpxjbj1xdmvchpztmcxtlqjtk
37hrqnnknjpcmmfhnbbmsps
9fcsix51foursckzjtffvv
gddqlqfourninenine65
tgqvzvcnxs5lffnzhtd
3bqfb8psxv38five
fourcskck3seventhreefour8
six1sevenjdvjkrn6six88
threetwothreeone87jlhgbrtgvdrt
sevenmsldjlpvzhtwosix4threefour
cthhqm2oneeightfour
rpbbnszfxg8ninetbeightfiveqskfzcf
sbjghdfgheight9seven
nfj59pjhrzfourfive
twotwoseven6nxxblhkdxct8
5lgxnqdfiveninedtdonespkvnonelzphcrxr
7qkphfqbbjvninedprb8cgmpcmsz79
fkmhvlvjgczxsllskzdone8
dzjvft8fivecpclmdtwo5453oneightt
6bjbvjgm
64ckqzvnjdhnine
four5eightwon
six3vggtzjxtsjfpbqh
7one5
onezccmbfq3
7gseven3seven
nxsevenone6ninep
hmmz2hvmxcmqtsrxdllrnzrgzcx85three
mskcmjfdvxmxlv5dnhhkvhx
krxjnz48sixzpqzppcngmsixb
7threedgsgseveneight
nfhpdbs4988
fournnfsjtwosixtwo2fourcnvdgmcfive
ptfhmlmjzltftmn2nvxvksbqhl7two7gdxb
threehqgqzx32
598flbdmfivenine
1tvrxqvsixfour
threedz8fourthreencxs
8foursxvfourlrgqjh
31vjeight2nfgkjvjqseven
one2lvvlseven9
fournine5xtpl
2fgfbjg
2onefour
one3vbrbkjmkqxs9t
jdgcvgcfsdbhvmeightkf8onenine9
2onekqfmjcftms
seven68two4zn
sevenvqpmhtxhncvff5one
mfqgljnmonepldmbnqphhtdonefive3xr
rrxkcnineninebsh3sixnine
81ztjznine
mgkgddsonethreebpmhnpfnqjjhzthreehdpnzmht55
3five3
jeightwotwobqsbczrlfgj7
6pvghfqtfjc
three3onenine4pmtfive
rnrdbjxtwo7fivesevennlpfrcptqtwofiveone
7psthptpvbh2
4bvsgkshslg44vkfour
three1tworkxhhps
299one
rghnkhlxqz91
76twocfcrone3
97dkkfonen6jnsmlh
2hnqhcpr4
seven7llhskvhnxz4
6ffjvvdgbtdxpmvdsk5qvppxtgblpvl
btsl8threenvhjkcckkgfsfnjgthree49
31vvmjfz
hjbkfgnmk35four4kgxb3two
5zkljxdhzpcfb7five8zpsckrfkvbeight
8onefourtvdgninenfive
6eightzcvfourrzqp7
3foursevenxjkmnnvqhq
5274eightwohx
vktjgvnztldsfbnqgqt9seven35
j5xqqltd3fouronesix
4bnpgeightsxlrbxdsnbdc
3zzxtcs8
ddjd13zpfqqx
fivenmninerrzkdp1
oneone989bn
sixfltmpjjqnmfpln5
5ninedn
562
47eight8hqsvhpk
nreightwofjnkrsgcdnt75
four1qvdfsfthgbb3kjrlh
shtf21
cqdlfptg2zzninelsmgpvqvrqnz7
shsjvztwonine8fourgrtgbdfdlqjvmktnrt
xpjzeight9rr
56fourcjrnmttqp8two3
3sevennxshxncmcfnxpv
fourvjgpcsqfjmtwofour9nine
twogjvtlpnsmcjqkgkkj7fivefmmthrfs
four9kssrrzrlbqeight
three4eight1xzrqjpxpnxqptnqvmqsdj
6phjpjd
5twoklcnsq1xcone
seven1bvnpqqkqcmzdllhj23five
ff19sknzln8jrdlhptfourz
rdrtwonehvdxccpftplzfqpzcrjsix6pfr
seven3llthreeshcb
qqzlgseveneight6one15four
7pzmfpvzdhhnxpsxd4vrqbmgtxjcsvfxdnxjzsevenkd
threelvkggjfivemlddrfrrllgfssfmgs17
tcbckd2
7four7krmsixffv9threethree
glvknsmmgn2onexjdskcqq3threeeighttwo
1fpt3
qddscqpjlpnnlsneightkm6sixnine
hppd1xlkgsmtfxxbvcgzbdfournine
pqdmrhvxdqbrkgjdc36mbq
rpllrjvrvfourfivefour3
two5neightsevendmp1ninehjfvvplmfc
gppnq7
foursix81onefkhzshsfxlxgxjzdd
13five
3sevendjlgttvnsevensjpgsjt7
172
three69threefour
3tcnfpzpkz
5vxzzfhg24bznvrmsjmtfmfjgxdseven
szhmlqxfffiveeight71nine
8five89zjvjqtpmlqveight5two
5twopjlvzlrltv
sbjtbfqkshrrtlrxvvq97jrflnxcrnfive3
qhoneightfoureighttwo5xssdqmvljfivenine5
3eightsix3five9
treightwo3sqzninenine1sxk85
oneeightxklmdbfkqjfour9threetmlnine
lxfxplrqeightninethreeppfnzfvndjn8qrmsjq
5one55eightwog
tworlqkztqblj9ltxlshrhjlttnqzhsdbpzzzbxdn
53vvvsmxjvs
4nine2qpgvdtxldq4four8jnf
keightsevenhcvrpztgcvsxszqdlzd1threenpvszb
89eightvdvklpxfntwo
ndtqsrfjmtzgdptlp8pnnf4onelq
6threesevenfx
6fjbglhltcfdxcbnzlcrtwoneqx
3jxtvj1onemxbqxlnm6sevenjzkhljktcm
twogkljgjbxzhlnrdxkhqvsevenqqttpjnx3
jmdcbcllcv1
3twosevenxgtbzsfhrbxsgk9sevennine
372
52qzldrtxqxnfivekkdqqs54
gcmnp51hxhvdbk22gdvdfour
6bpdjtwoqmqtvzqfive
4zmfthreefivefoursix1csnrznptgr
hrdpbqfonefjqbbjrnine9onenine1
47bdtqmbdvhmsf3five86vhclmd
295two7four
3onenineseventkgxthreetblbmljhkhfour5
4four8fourthreek36
5rqnsvdhkbrvrltcqpsd
six4fourfourthreefour
4967
99
71seven9kcmclngvpmlkkfngssveight
79eight9six
3sevenp
seven69lxsllgjqdvfoureightfive
8six5grssfgfr78two
twomkpjc18fkkhlnkgkxfjnine
g8qcq9xqlzgzmmrf5vhm
zsix8ssfrjqbnztttvszlsqeighteight4slzcrnkvf
dmfive1ffprhgfnrx49
7cfdcptvvnvhfivetwo
18kqkxdlnhjbqoneszclkzljhnhqd
52lcclkxsix
three7five5cjtgpzjfoureight
53pchxqfpcfddsqzl7oneeight
ctjg84hqsjxfive
1znmjftpq7xbxt
nine71krj7fivenine
pgr6lfbhkpsjhhjpgqnxtxmkpdktnine21
xhkeightwo14four23eightqxhpct
x1
7357fivehfbbgdhzg
rktbdvm41seven
6fshmcmxdsfgxrcfvone
nndrdq7six
5two7r
one78gnsdkhkqfourfdsghnll6g
3sixht
96mbxlpgctgf1sixfivefour
2sixbcqskzpqbqtt8sixrtngznb2
twoone9fvmczldvtk
4jpfmgzgdhs
3ninefour
61nine
8kleightoneightrhf
51sixg
pckfpxzmrthreejvh8eighteight5
ssmgkkblkfive68eight2
nxkxdtckfb95bpdtrdhhltjdqpnine6
kqjkvndr3lfqthvmbrbfgzrbcntpcrd
44sixtwonineonefour
gtvlneighteight5961nine2
14lzxzbvbg4sixeightpthgz3
8814eighttph
7rpf8fivedkfivesfxgkjmniners
six6zsxzcfmcxzn2
four12dkgnmsjqtjp7zmzbsp
8two69six
three13six4three6one3
threedfmcmxgxzhglv36five
8kkjrbkmbt2
jhttwone3fivethree8ninehjgnvmxtkdcpmhhvrb
sixtwofourseven86zs8
26seven
28three6
qpsznsqqfb4ntcdf
9zbqnvnlgrjcnpmbkdmtvmdfouroneqctnnm2
onefivekpfrdbxcmn3sevenonerfzmcsvbjgtcxndv
seven814nskmxzpcnvfppntrssthree
74jfmrfkznsfiveeighttwofivethree1
sixgh8
fhnlhfour3jhrzjdsrfour4five
qgzblcqp9
jrk377gdrjfldpqmeightffrlxffive
36eightsixgvninezkl
3hshcq9r
dmrhgkv2njtwo95
6pktmsdxpmpvmpfc4eight
five1five6hnpbzpmcccnqpfive
lmsbmvmrrljf4ninesix4threertxtsvfour
419six
tstsix3six
37seven
sixtwovghcj32pj
x66four6
72twosixnvdcq2nvkmgbsb
kvxprh1tnlrpmcldsshh5kcdfxmbcbfour
2threekqqcvtxjrktkqpddqhfourpbqqcrgbdeighteight
rltdhqvnm8
sevenninetjvvfxcv7
bhmkxpvhrqkfive8fourtwotwo1lcbkk
threepcnnzhkbzfbhqtn3eight544rtsrtcc
eight7onekqdvzvsmxcpgfjlllhtptnrmv
47zsqd2pnsgjhpkxljpvnine
8ldxnsfour
two7vpjfvhtmqdcrqlonekkqrnc32
12znrsmjqf
eightsixeighttjjhqsevenns1qbkstj
pcpcrqshftwo4
sixtwoninenmffcmfldb81
five75pvngkvx9nnlttwotwonev
1739lkzpsfzdsixfoureight
threekqvbcfiveltbrtjjtdcchtjthxvztkjpd3eightsix
qrxtwonefive9
96zthtvk8228bmfllnc
tmnsgdz3fourtpmtcvtfqdcteighttm
rmpbtfqxmmtwokn5two
ninefive65
qzmthdvvzmxthf82fivesevenbvdt8dscnl
onenfhgqqpdrtxvzn961sxjhxlg2nmxzkbp
9eightone
fourfhnzmcfour6lshj
eightzlffkpcbrbjjpmjrz7tcgjonefourthree
twomdzv77four2437
bvcgtrxthg863
4fpmpsxzdshdszvckpxqkgfourxnrpp
one3sevenmfmlk
eightthreenvfp439
bm9
jssc74tlhvfdjs6kdxzrskxrdtfqnnkfczr
v2eightsix
eight2mflbkmeightqfivethreefour
fdchmls7
7cgtkzkdvkfour
one237
69tfpdbmcrbqq1
poneightfiveninefivetwosccxmtbf28
87sevenpzbjhjvqonetwo
xsbsqpdlp9threejpjmrctbkrjrsevenone
cmhxdcpl85jhtpnttwonzlcrcfivevxxqn
1zxccxdpkl9tdqkgfxsevenvhlrmvfhvvzdzbk
lqmnvtdqngqjh355
mcsttwo43bsdrtt7three9bhlh
pvmtwonefour8eight8
2tgcpztjnqkldhshbmxnm
5zqkkcnnsh3
vqfmjzln6xnrpnrpqkdpqfgxfnine2
87eighttwo1
sevenxrdhnpz87zzjzhxcbbxqxeightsixoneightssl
pdpgbbhpzzmhqfhkprgx1twoonethree
gggfnvtxvpsix6slxrninenine56
dxbhdfrvgqkhch5seveneight
7five3
fourfive1fourptggnine
three6npf45kjrbrg94nine
4twonev
4rgpf98two
7chcnzghmcznftwo5
dvskzxcgnljmgxfntwo73
qboneight5nine1vftwotwo
54lqlzgjqctwosix
zxqnine57
3onethree
eightfive2xxxtwoblfjhlq9b
6ninesqvjsrz813
6734
2jcxkckrj7crncbonevskt
167fivef1
three9five2eightfivetpdlpxljgnineone
9two6five
xxktwoone2crphztrtndrjgs
gcjzskxzmtwo45seventwoqvzpfive
8phdzrrlkhqjrmlgshlmonefggsnslj
threer3oneeightfive43
six1one
dzoneight8
sdztwoneghxmqxlgv68
9onecjone9ppvlt
2svml3fourfl6five
clknqq83ninefive
1tgfkdnqgoneightzf
9onesixfiveqcclnl
onedvchs4
strmhlxs2threefouroneseven
dpbxhlgkzbtwo32nrdtwo
seven38sixfivehlkdsj12
eightfive6
8sevenfour8mknvzhfnzvbjplldpqkvvrcrmfourfive
xmzjtktmsixsix2ninesvqgxc
7fourbpn1four
8nineqksmfivevdknb
8kfv4ldzf
71fiveeight
bbmtpsdbnktndcnthreethree2jeightsevenxl
ntggphnine3
6vfb5
9pqjp3fivedssspd
pmsixeight7x6
1nine5sixoneightmm
threefbhsjcqrstdzkfgsllpktqljnlsevengbvpmvhlthree5two
9rqfdgxl4pgfbdsfonedbmjqthnsevenone
ccqknlg29bzxdrdx
vtbjqtjhr23
sevenvstvhd1ninesix
sixdjszthree7
6jhnj4
2fivenjrfkz
one55
69fourvttjxr
kqpqtkss7lxfxsfsmxqkfpcrjm
459xr
46nzsfive
s4jhbqgpmsninesixfivefiveone
4twofivefive
528nmtcfptktmfivesixfour
78qnkp
zbgrb4mskvlrkcftbpjr2twones
tvcjhbv4nine
three6mxsxvlljdnsgtzrfouroneightlp
6jc7two
one9kmkrvjrzbv6eight1seven9seven
fivesixstjrxhn7zmjthsdk3fcjsq6
ncbzqeightfivetbpmzrvp44ctpjhg
sevenrgvgkzktvjdd92
5eightsj
83nine7hzjvjxmbn
sgspsggkbzfour9
two5fivetwofive41eightwosm
onejmk5eight
nine11
xlhx53qrnvqfiveclj7six
oneeightone1five8one14
56d3
5sevenseven9dnhkhhpjzbqkrt31
r6one
sevendh46
eighttwofivesevennine915eightwomjk
four26three
sixrspdrhltrseven3
3bf1two
6ts
sevenhnvgvkhztsqbqcvm17btpzrrrfpsnr
eight8fourldzrzhpmppkcfcchtzpteightthree5
124
379qtfive
4pp
128pqgtqrjdhlrfivesixthree
f7ninesix
16hqkxjnmd
9sixsix98qhblkzh
13nine8glvsfkrqs
ninegdnhsfgckc7two
onenine69lzqx7gxhcdcg34
67993fivexcx
nine6dbqrthree9five6bone
zvfmz6thgmqgqsvnqpxtdx575
eighteight2
five2five
lprqsrxqceighttwo744mptdngcgmchkg
1seven3ztfhcsrkdj76rmjz8
h4fiveeightfournineblvhhnnqpsix
sixk4
nine7vhpkkztwo
8jfrfchzpk54sixcfbdfrccpv3
9zkxnqjfzcrdseven8ninefivenine
ninefivenrfmttdq9vgtnqsxcmh
5tgjvsix5
722fvzzn
23threethree
7two5hszrj5nineonethreedp
2lpdzpzeightfive2onethree
lptvrd5qjnstntpld44eight6bflqd
ldh1three
tx9kgbrrvthreezkxhpn6
g5gks6fivel
hlblkd3threedcqhbtmktvtzqrmjhgtgtxnfbbdffmckbqxxp
dfjmnine71vfndzz
66eightfivepzqvsrlrr5
seven2threeninemcmlhfmkndhtdeightthreethree
6ktfgglmnvjgxsevenfourjzgp6eight
76zvbblfrthreeeight2ninefive
fivetgprhplmsmhslrtpr31six4
sevensevenone71rgqb6three8
34htvldclbxmeightwon
five1klzmf3
5dqpfivethree4
p6
xrtwone719
tmtwonefive3sevenqqpz8twotdsn6
qvcdkggrh644
899tnqhhzcjxxllmp139prgx
sixnrsgvmrggcl6
ccjq3one
5threejbhlrrlone1four
ninefive1ninevhndvmrbqzcnlccptbvl
3sevenonepnjxhkbtc
3ninelck34eight
jmjcc88trmxvsvkgxdjlh78jjtwo
mpfpnqqrsspmdjpkmrrlljrlsddnsix38three
mtttwo97
4xfnjbsplqnxtns13qlsnbhn
eight69eight
two6dtrfmgh4
qtgvqlzp175zxt5
sgmqvl9tmnthree2
db47six6nkgdqvc
6jrsixlldvpn2onekrqninejh
gdrqhbkpg3one
7threeseven8threegqlml6mjmtc2
nptwothree8five
8kxmjpnctddeightnine5twonevzf
threefour7fivelhvxvhlqzfn
spfgjxkcnfourllmv3v9four
7xzksddd7v8pjrv4five
68fq1four
threel6dd7one
pnrsevenseven5four95
4sevenqlzjjcdsvfdtzcjp
1kxfmrsix58ninenrmmlvtd
743threeqfxmmtvkczhteight
bslvhvlspr8dsmhjlrcfjsixnine
2mpjmtrrnineeightklxflnvgr
gxnzcrf4xvgcgb9one368
4three5j28xl
2seventkdnfrkvnd7
7llbkvzblfdtwo667six
two7onethree2fivesixhgjg
gthreelprkltjbqp7sevensix
q41cpcpjh
nine42fivefzztjknfv
five3kblrgsonedxjhsnxfour56
fckqjbs1cbblpbvtxdlcvtwotwo
9xvjszgkbcfourninerp8nine
vmlx27oneqzmffghcmfpn47
tjschpthreecbb6sclbfivejzlbd
77sfzkxdfdjnbnseven3knnqgvjbm
threeqgfcrn2
four7qcrxlcjsklhjcsz2731
sixreightsixqhflvseven8
1xxngrjnfsixfiveslrfivenkplbgnqxg
onefnhbcjqrthree7jlbcfgdl5
81oneightrgr
sixmqgdfgscr6three
sixxlcsix2
1zrqllfszlhqgp2
pcvrlxfml5znrjc542
pctzcvgrfj82
jnrlqsptfivetwokghkr8sevenlzdf
kfbdrtgtgsix9sevenone
ppzqjzvvfive39eighteightthree
bzblbmns62seven7jvdgxknx1one
foureightsevenmtwo7
3dxbt6h
7phdxhtsbmfzmhzlsh3four
fsrcjfour2kllnxdbfhnine3six
dp6sevenseven
nqf3pv7
fivesckjvndbf1eightfivejqzcsn
eightqxbx3jdzmcsvrpv9fplreightzdrlbpfj
one6twoeightkrrfdgrttxvthgfour
sevenseven3sixsdrtj
rstsevensix4oneseven7mrccrxmht
fourthreehjthr8five
fourxmxncslkq71
seven1b5two
3four9eightfour34
76one6four
sixsixpzghqfqndvpcmzt4tftxxpjbghs
fouronenine7eightwot
two77mplckblrclfqgpgsx24seveng
eight6twoeight18fczfn5four
7dxqshsmhrvbnfgjq5
nine52three
3thbtwo
two9sixeightoneeight
mklp1qqgkgcceightfour77
13onermtxflmnmq8qxhkhxthree2
397rhmknine96rzfgbr
8fourseveneighthb67
89625t
fbfxgqsqhthree74seven5
8threegnqhhpfx
zdsfs682
76lqkvfhtdpseven4lfpvkxjgqtwobbrz
7zthreesevenfour9four
ninefc6eight4two5oneighttfn
eight32
eighteight6lqgrgbntgkkzfqdjhxtwo
8vdzgsqnsix551
6klxfrfqzbsrnxmmdbnqbvfpzcjtx5two36
nhcdmxpvg5kmmknrnine
17tpsvtclthree
five84eightfjrznfsrb
fjzfb6onefourhtlmvlns
zqmmfdkl8
3sixeightnkgpssqnkrsclmshzzfhxxhvxlsljgfgnltbpc1twoneqd
8frbccqkvdtwoc
zeightwoeightptmkdhx3eightnineqx4
pbfnine6three8six5jtxmeight
eight78
1bhlgn5five
xnhhlgfrqbgfhhnvllhptfh3
ljjllzbbffpxcjrztzthreermg6fzqqpd
72mmjrfjvlzone3threethreesix
fiveonecfsfsix74twocllbfnptkgttf";

    [TestMethod]
    public void Day01_1_Test()
    {
        AdventOfCode2023Lib.Day01_1(inputDay01_1).Should().Be(142);
    }

    [TestMethod]
    public void Day01_1_Final()
    {
        AdventOfCode2023Lib.Day01_1(inputDay01_Final).Should().Be(54561);
    }

    [TestMethod]
    public void Day01_2_Test()
    {
        AdventOfCode2023Lib.Day01_2(inputDay01_2).Should().Be(281);
    }

    [TestMethod]
    public void Day01_2_Final()
    {
        AdventOfCode2023Lib.Day01_2(inputDay01_Final).Should().Be(54076);
    }

    #endregion

    #region Day02

    private const string inputDay02 = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
    private const string inputDay02_Final = @"Game 1: 4 red, 8 green; 8 green, 6 red; 13 red, 8 green; 2 blue, 4 red, 4 green
Game 2: 5 blue; 1 red, 3 blue; 1 red, 7 blue, 1 green; 1 red, 8 blue; 7 blue, 1 red; 4 blue, 1 green, 1 red
Game 3: 8 blue, 5 green, 15 red; 6 red, 6 blue, 3 green; 8 red, 2 green; 10 blue, 10 red, 6 green; 8 red, 6 blue; 15 red, 5 green, 2 blue
Game 4: 10 green, 12 red, 14 blue; 5 green, 9 red, 7 blue; 14 blue, 12 red; 8 blue, 7 green, 11 red
Game 5: 13 blue, 10 red, 7 green; 3 green, 8 red, 4 blue; 16 red, 5 green, 5 blue; 2 blue, 9 red, 7 green; 5 red, 14 blue, 3 green; 2 red, 11 blue, 2 green
Game 6: 3 blue, 1 green; 10 green, 12 red, 6 blue; 3 green, 2 red, 5 blue; 2 blue, 11 green, 2 red; 1 red, 5 blue, 9 green
Game 7: 2 blue, 10 green; 3 red, 10 blue; 3 green, 8 blue, 5 red; 8 green, 10 blue, 2 red
Game 8: 15 red, 12 blue, 5 green; 10 red, 12 blue, 5 green; 10 red, 7 green
Game 9: 18 blue, 14 red; 3 green, 9 blue; 1 blue, 11 red; 5 red, 7 blue, 3 green; 8 red, 4 green, 1 blue
Game 10: 2 blue; 10 green, 4 blue, 3 red; 5 green, 4 red, 4 blue; 1 red, 3 blue, 4 green; 2 blue, 5 red, 3 green; 3 green, 2 red, 2 blue
Game 11: 4 blue, 19 green; 19 blue, 12 green, 17 red; 11 red, 10 blue, 17 green; 9 green, 18 blue; 14 green, 9 red, 18 blue; 15 blue, 6 green, 19 red
Game 12: 1 green, 6 blue, 2 red; 6 blue, 2 red, 8 green; 2 green, 2 red, 7 blue; 1 red, 3 blue, 6 green
Game 13: 2 red, 11 blue, 4 green; 2 red, 7 blue; 9 green, 1 red, 12 blue; 13 blue, 8 green; 11 blue, 8 green, 1 red; 1 red, 2 blue
Game 14: 1 green, 4 blue, 11 red; 11 green, 6 blue, 7 red; 7 green, 6 blue, 4 red; 12 blue, 10 red, 11 green
Game 15: 1 green, 19 red, 3 blue; 11 red, 3 blue; 20 red, 4 blue
Game 16: 3 red, 1 green, 7 blue; 3 blue, 4 red, 1 green; 6 blue, 7 red, 3 green
Game 17: 7 blue, 4 red, 19 green; 7 green, 4 red; 8 green, 2 red, 4 blue
Game 18: 1 red, 1 blue, 6 green; 2 red, 6 green, 1 blue; 4 green, 1 red, 1 blue
Game 19: 4 blue, 8 green, 6 red; 2 red, 9 green, 4 blue; 9 green, 8 red, 6 blue; 3 red, 6 blue, 9 green; 8 red, 4 blue, 7 green
Game 20: 3 blue, 7 green, 13 red; 13 blue; 12 red, 14 blue; 3 red, 6 green, 8 blue
Game 21: 5 green, 2 red, 10 blue; 2 red, 2 green, 6 blue; 1 blue, 1 red, 7 green; 4 blue, 1 red, 2 green
Game 22: 2 red; 1 green, 7 red; 3 red, 1 green, 1 blue; 4 red, 5 green, 3 blue; 1 blue, 2 green
Game 23: 15 red, 1 blue, 3 green; 6 blue, 3 green, 2 red; 6 green, 4 red, 1 blue
Game 24: 17 green; 1 red, 2 blue, 3 green; 10 blue, 1 green; 1 green; 1 red, 2 blue, 1 green
Game 25: 2 green, 8 blue, 1 red; 1 blue, 1 red, 9 green; 1 blue, 2 green, 2 red; 3 red, 6 blue
Game 26: 12 red, 19 green, 4 blue; 2 red, 10 blue, 15 green; 14 blue, 17 red, 3 green; 1 green, 15 red, 3 blue
Game 27: 11 green, 1 red, 9 blue; 3 green, 10 blue; 9 green, 10 blue, 1 red; 4 green, 3 blue, 1 red; 2 blue, 5 green, 2 red; 17 blue, 2 red, 5 green
Game 28: 10 green, 10 red, 5 blue; 5 red, 4 blue, 8 green; 3 green, 10 red, 3 blue; 2 blue, 8 green, 1 red; 6 red, 1 green, 4 blue
Game 29: 3 blue, 11 red, 1 green; 5 blue, 3 green, 6 red; 8 red, 12 blue, 10 green; 1 blue, 4 red, 1 green
Game 30: 10 blue, 1 red, 2 green; 1 red, 8 blue, 2 green; 4 blue, 3 green; 5 green, 1 red, 3 blue; 3 green, 14 blue
Game 31: 3 red, 7 green, 6 blue; 11 red, 4 green, 2 blue; 1 green, 11 red, 8 blue; 6 green, 5 blue, 5 red; 4 green, 3 blue, 15 red
Game 32: 9 green, 1 blue, 10 red; 13 red, 7 green; 12 red, 6 green, 1 blue
Game 33: 9 green, 4 red, 6 blue; 2 red, 4 blue, 1 green; 2 blue, 11 red, 9 green
Game 34: 8 green, 6 red; 4 blue, 3 green; 6 red, 1 blue, 9 green; 10 green, 1 red; 2 red, 2 blue, 2 green; 2 blue
Game 35: 4 blue, 8 green, 8 red; 1 blue, 10 green; 5 green, 8 red; 4 green; 6 red, 1 blue, 6 green
Game 36: 4 red, 10 blue, 16 green; 18 blue, 5 red, 5 green; 16 green, 11 blue, 1 red; 6 green, 10 blue; 4 red, 9 green, 17 blue; 1 red, 9 blue, 14 green
Game 37: 1 red, 13 green, 5 blue; 2 red, 12 green, 12 blue; 5 red, 11 blue, 5 green; 9 green, 4 blue
Game 38: 1 green, 12 blue, 1 red; 11 blue, 3 red, 1 green; 17 red, 11 blue; 8 red, 2 blue
Game 39: 11 blue, 12 red, 1 green; 1 blue, 1 green, 4 red; 3 green, 6 blue, 3 red
Game 40: 1 blue, 1 red; 9 green, 2 red, 2 blue; 9 green, 3 red; 8 green, 4 blue, 4 red; 3 green, 3 red
Game 41: 7 blue, 8 red, 3 green; 4 red, 7 green, 1 blue; 5 blue, 6 red, 5 green; 4 blue, 9 red; 2 green, 9 blue, 5 red
Game 42: 8 blue, 17 green, 7 red; 6 red, 11 green, 13 blue; 7 red, 3 blue, 14 green; 2 red, 12 blue, 2 green; 18 green, 8 red; 10 green, 5 blue
Game 43: 5 green, 9 red, 3 blue; 3 red, 5 green; 6 green, 1 blue, 10 red; 8 blue, 1 green, 2 red
Game 44: 1 red, 5 blue; 4 green, 6 red, 2 blue; 12 green, 8 red; 4 blue, 2 red, 9 green; 1 blue, 5 green, 3 red
Game 45: 9 blue, 5 red, 6 green; 10 blue, 7 green, 8 red; 1 red, 1 green, 10 blue; 2 red, 1 green, 11 blue; 11 red
Game 46: 14 blue, 8 green, 2 red; 10 green, 8 blue; 7 blue, 12 green; 14 green, 10 blue, 2 red
Game 47: 5 blue, 7 green, 1 red; 5 blue, 5 green, 3 red; 2 red, 8 green, 3 blue; 2 red, 2 green
Game 48: 2 red, 2 blue, 1 green; 1 green, 1 blue, 3 red; 1 blue, 1 red; 3 green, 8 blue
Game 49: 7 red, 2 blue, 8 green; 8 red, 4 green; 2 blue, 4 red, 8 green
Game 50: 9 red, 4 blue, 10 green; 11 red, 7 green, 4 blue; 4 green, 16 red, 2 blue; 13 red, 9 blue, 3 green; 1 red, 6 blue
Game 51: 8 blue, 2 red, 3 green; 2 blue, 2 red; 4 blue, 1 green; 1 red, 2 blue, 2 green; 5 green, 6 blue, 1 red
Game 52: 12 blue, 8 red; 11 green, 9 red, 11 blue; 8 blue, 5 green, 8 red; 3 red, 11 blue, 11 green; 12 blue, 6 green, 5 red; 10 red, 8 green
Game 53: 9 green, 6 red, 3 blue; 4 blue, 5 green, 3 red; 11 green, 5 blue, 2 red; 4 red, 9 green
Game 54: 13 blue, 8 green; 15 blue, 3 red, 7 green; 8 green, 1 blue; 8 blue, 3 red, 6 green; 3 red, 1 green, 12 blue; 9 green, 3 red, 2 blue
Game 55: 2 red, 1 blue, 2 green; 4 blue, 3 green, 1 red; 4 red, 7 green, 4 blue; 7 green, 3 red, 1 blue; 2 blue, 4 green, 1 red; 5 blue, 1 red, 4 green
Game 56: 14 green, 1 blue, 4 red; 3 red, 1 blue; 10 red, 8 blue; 8 red, 7 blue, 3 green; 3 green, 12 blue, 4 red; 7 red, 2 green
Game 57: 7 blue, 8 green, 6 red; 7 green, 5 blue, 3 red; 2 red, 8 blue, 9 green
Game 58: 7 green, 8 red, 3 blue; 7 red, 5 blue, 9 green; 4 blue, 3 red, 9 green; 1 green; 5 green, 2 blue; 5 blue, 7 green, 2 red
Game 59: 2 blue, 10 green; 8 blue, 10 red, 1 green; 1 red, 10 blue, 7 green; 2 red, 7 blue, 1 green; 5 green, 3 blue
Game 60: 1 green, 2 blue; 5 red, 2 green, 2 blue; 2 green, 3 red
Game 61: 3 green, 2 red; 10 green, 7 red, 2 blue; 8 green, 2 blue; 5 green, 3 red, 1 blue; 12 green, 1 red; 1 blue, 13 green, 6 red
Game 62: 11 green, 2 red; 3 blue, 3 red; 2 blue, 1 red, 10 green; 11 green, 3 blue
Game 63: 7 blue; 7 red, 1 green, 8 blue; 5 red, 14 blue, 1 green
Game 64: 2 green, 12 blue, 1 red; 18 blue, 10 red; 9 blue, 2 green, 13 red; 1 red, 1 green, 15 blue
Game 65: 6 blue, 8 red, 8 green; 2 green, 9 red, 9 blue; 3 green, 9 red, 1 blue; 10 red, 4 blue, 2 green; 7 blue, 5 red, 5 green
Game 66: 14 red, 3 green, 9 blue; 3 blue, 7 green, 12 red; 5 red, 8 green, 1 blue; 12 red, 5 green, 4 blue; 5 green, 14 blue
Game 67: 1 blue, 9 red, 7 green; 12 red, 9 green, 1 blue; 13 red, 4 green, 2 blue; 1 red, 1 blue, 5 green; 10 red, 2 blue
Game 68: 12 green, 2 red; 1 red, 4 green, 7 blue; 3 red, 4 blue, 14 green; 6 blue, 6 green; 7 blue, 4 green, 3 red
Game 69: 2 green, 17 blue, 9 red; 6 blue, 3 green, 4 red; 11 blue, 4 red, 6 green
Game 70: 11 blue, 10 red, 12 green; 9 red, 10 blue, 5 green; 2 red, 3 green, 9 blue; 5 green, 6 blue, 6 red; 12 green, 8 red, 10 blue
Game 71: 7 blue, 3 red; 1 green, 11 blue, 1 red; 1 red, 5 blue, 1 green
Game 72: 9 red, 7 blue; 1 green, 6 blue; 15 red, 6 blue; 5 red, 4 blue; 4 blue, 4 red, 1 green
Game 73: 10 green, 4 red; 1 green, 5 red; 3 red, 1 green; 1 blue, 9 green, 6 red
Game 74: 6 red, 3 blue, 8 green; 5 green, 9 red, 1 blue; 1 blue, 1 green, 2 red
Game 75: 2 blue, 3 green; 3 blue, 7 green, 1 red; 6 green, 1 red; 5 green, 1 blue; 7 green, 3 blue
Game 76: 4 red, 2 blue; 1 green, 7 red; 2 blue, 3 red; 1 green, 1 red, 1 blue; 4 red, 1 green
Game 77: 18 green, 19 red, 11 blue; 1 blue, 18 red; 5 blue, 10 red, 16 green
Game 78: 3 red, 8 blue, 1 green; 2 red, 3 blue; 1 green, 6 red, 12 blue
Game 79: 5 red, 4 green, 9 blue; 3 blue; 4 red, 5 green, 2 blue; 7 blue, 5 green, 8 red; 5 red, 6 green; 7 blue, 5 green
Game 80: 8 green, 11 red, 3 blue; 15 red, 4 blue, 8 green; 6 green, 14 red
Game 81: 11 green, 5 red; 7 green, 14 blue, 4 red; 7 red, 8 blue, 2 green; 10 red, 3 green, 18 blue; 3 red, 1 green
Game 82: 2 blue, 5 red; 3 green, 5 red, 7 blue; 3 green, 4 blue, 2 red; 10 blue, 2 green, 2 red; 8 blue, 2 red; 3 green, 3 red, 7 blue
Game 83: 7 red, 12 green, 1 blue; 5 blue, 17 green, 5 red; 9 red, 3 blue; 2 blue, 1 red, 20 green; 5 red, 6 blue; 2 blue, 3 red, 11 green
Game 84: 1 blue, 7 red, 6 green; 6 red, 8 green, 10 blue; 8 green, 1 blue, 6 red; 8 red, 4 blue, 6 green; 3 red, 12 blue, 8 green; 3 red, 2 blue, 7 green
Game 85: 1 blue, 1 green, 8 red; 9 blue, 9 green, 2 red; 10 green, 12 red, 7 blue; 7 green, 2 blue, 7 red; 7 red, 3 green; 11 red, 9 blue, 5 green
Game 86: 4 blue, 8 red; 4 red, 3 green; 7 blue, 12 red, 4 green; 4 green, 8 blue, 3 red
Game 87: 6 blue, 19 green, 5 red; 20 green, 5 red, 5 blue; 8 red, 3 blue, 9 green; 11 blue, 7 green, 7 red; 17 green, 11 blue
Game 88: 1 green, 2 red, 5 blue; 2 blue, 11 green; 3 red, 3 blue, 6 green; 4 blue, 2 green, 1 red; 8 green, 4 blue
Game 89: 19 red, 15 green, 10 blue; 17 green, 1 red, 4 blue; 13 green, 10 blue, 15 red
Game 90: 3 blue, 1 red; 4 blue, 1 red, 1 green; 4 green, 3 red; 4 red, 4 green, 5 blue; 2 green, 3 blue; 4 red, 2 green, 4 blue
Game 91: 8 red, 4 blue, 16 green; 17 green, 5 blue, 4 red; 10 green, 6 red; 11 red, 7 blue; 14 blue, 4 red
Game 92: 1 green, 3 red, 1 blue; 2 blue, 2 green, 5 red; 2 blue, 8 red; 1 blue, 2 green, 14 red; 3 red; 1 blue, 9 red
Game 93: 11 blue, 7 red, 8 green; 8 red, 6 blue, 5 green; 4 blue, 4 green, 6 red
Game 94: 2 green, 1 blue; 5 green, 5 red, 4 blue; 7 green, 2 blue; 5 red, 1 green, 3 blue; 2 blue, 1 green, 5 red; 1 red, 3 blue, 5 green
Game 95: 3 red; 7 green, 4 red, 7 blue; 5 red, 5 blue
Game 96: 3 red, 5 blue, 1 green; 3 blue, 14 red, 2 green; 7 blue, 3 red, 2 green; 15 red, 5 blue
Game 97: 17 red, 8 green, 6 blue; 8 blue, 9 green; 4 green, 18 red
Game 98: 9 blue, 2 green; 4 red, 6 blue, 3 green; 2 red; 14 red, 12 blue
Game 99: 4 red, 3 green, 3 blue; 2 red, 2 blue; 7 green, 3 blue; 5 red, 2 green
Game 100: 5 green, 7 red, 4 blue; 11 green, 9 red, 8 blue; 2 blue, 12 green";

    [TestMethod]
    public void Day02_1_Test()
    {
        AdventOfCode2023Lib.Day02_1(inputDay02).Should().Be(8);
    }

    [TestMethod]
    public void Day02_1_Final()
    {
        AdventOfCode2023Lib.Day02_1(inputDay02_Final).Should().Be(3099);
    }

    [TestMethod]
    public void Day02_2_Test()
    {
        AdventOfCode2023Lib.Day02_2(inputDay02).Should().Be(2286);
    }

    [TestMethod]
    public void Day02_2_Final()
    {
        AdventOfCode2023Lib.Day02_2(inputDay02_Final).Should().Be(72970);
    }

    #endregion

    #region Day03

    private const string inputDay03_1 = @"467..114..
...*......
..35..633.
......#...
617*......
.....+.58.
..592.....
......755.
...$.*....
.664.598..";
    private const string inputDay03_Final = @"311...672...34...391.....591......828.......................738....................223....803..472..................................714.840.
.......*...........*.....*...........*........631%...703.......*..12....652.................*.$............368.769*148.................*....
....411...........2....837.121........511.745...........*.48.422.@.........@.............311........887......*................457........595
........*328...............&..........................144.*...................138............48.......*......682.........@...*.......777....
.....144.....+........170...................207............813..../.&....139..*.....346........*..147..143.+.....78....536..79........*.....
...........828...559.................181...%..........613.......10...928...*...993.+.........758.*.........471...#../...............573.....
....................*164...132..........*........=.......*.................47.........186.........313..............411......................
...............342............+..823.....533....519.....899...310................@........325...........15....................407.....#.....
515......916......*.@...........*.............................*......961.........827......*.......=.........567....=238...874*.......420....
...=.......*...207...882......719....455.973...................369...*.....*913........978...%..720..........-..............................
........306................................................182.....534......................229........744.........+.....=..........918.....
303...........745...........361..............223..243.129.....=.................830.....%.................%......493....106............&....
.................*209..17.........494.910................*90....496.....709......&....896...................................................
....%..562............*.....@...........*..528.......321...........*673......................887..%231...............700..............116...
.988..=....944...596........806...24..519./..........*......../...............146...........*...................554..*......................
..........$.......................................822...621..771..151.504.......*.628*343..34...+.&..............*..329.303..641..678..+....
........................361.....347*524..538...........*.........*.....-......790.............933..724......699...........*....*........262.
.716..517...+..........*................*......955$..544.....238..593.....399.......#..=...................*...........241.....930..........
...%.+.......744....550..........#131....964.............234..*.............*.....856..809..450....%....332.....419..................389....
........264...............798......................816....%....228.......501..224........../.......645.............*499.....*.......*.......
.......*.......939........*.....@..............795*..............................*........................789................907.....647....
.....612..........*.612..291..592........#.................567...................391.........................*....387............64.........
................24.....*.................814......=........$......./....346................444............833....*..........845...*.........
...........303.........605..326.....108.......%..56..842=.....*....387...*..478-..272=....*..........#........778.....299=..@...722.........
......484=..=.....753..........$......+.....449...............559.......144.............695.........675..................................253
...-...............*.........*................................................................987.......200......*......445.......124...*...
....825............603....544.634........................432...=875...738...............731..*.............&..488.363..*.....663.........876
........755.................................#............-............/.............*....*....470..314.145..............277...@.....234-....
....323.........221..............892...284..473.....44......342.622.........707....413...984..........*....../..............................
..............$....*..............*...&........................*.......351%...*.............................226..........155....973+........
...............177.991..........268.............532=......./.....277........183......*935.........917....*........825.....-.................
.....+.%................#...413........304...............384....*.................748........./....*...955.......#...........885.970........
...44...627..........368.../...........=.........................314..293...................102..108............................*...........
......=.........................=........733..433...128..............*.......889...........................661.........-358...$....281......
.....35..........$...........834.../699...../.-......................461.......-........*...................*..................374....=.#412
............763..201..$............................392........341........96......723.340.........327.736...1..$897.....471..................
.....*512..*.........221.............125$....257.....@.....................*.277.*................*...*................................@....
..301......694..............54.............../.........611...............596.../..100.......164.801....596..490....&361.........415....412..
..................243...927*.........29*293........645*.......862*2...........................=............*.....................*..$.......
............$......&.........655.906...........500....................125.613..844.........@......435......984....725-..531.....711..79.....
...817...450.....................*........431...%........................*..........957.....739..*.....................*....................
.....#........237......122.66.942............*.........548..................506.435...............73.883............644...101...............
.863.............*......&..*..................98..283........532......750..............*........#.......+....594*...........................
....*.........451.........623.....*....*...........&............%..50*.......44.....123......951.................62.943......365...995......
.639..............827.265......132..354.127...........350....................*..........................11..........*....%...*..............
........41..#175....@...*..*.....................+......*..247.353...#.....44.....912-......757...............144..481.693.271.........993..
.........*.............993.707...857*...........375.....90...@...*..386.......403.............*..................*..............208....=....
.......343.437....391..........&.....117....637.....345.........43.......*662..@...........908.........956.......908.............&..........
389.............&...........670.............$...42.....*...=..........564................................%...............+..................
...*............435....*.............913..............574..149.......................962....................953...77..641....514............
....448.....783.....892..381.....593.*.........................403*149................%..863*954....373-..+........*...........*.+...663....
906........................#......*...922.........950......................993...3.........................379....450.......877..804.#......
...............768.......*......-.198.........160*............820......382...*......169.........*555..257...................................
260..............*.....68.....281.......871...................*...980......875.......*.......169........*.............531......@............
....*......@.....587...................#......48..251..316@...848..................303................931..132..............790.............
.....205...572................696........&.....@.....@............709..611.............=.......270........*....165......783.......790.......
......................965.........709..826....................882*......%..775.........391....*......985.5........*179.....*47.......&......
.....451............@................#..................804..................$..161...........837..............*................$904....176.
720.................70..........899.....868..............=.......357.252.......*..................707.......898.139.....704............*....
....................................307*....510..................*.....*.......17..501.............*................@....*..........855.....
.............745............451................*..689..980..@670.594.716..........*.................565......595..622.....793...............
.....890......$...73...422...*...977&.......324..%.......@................29.......945....*.............298-..................#.........#642
........*........*....%......................................$645......-...*...150.....434.259..609*560....../............266..524..../.....
.....203..........133.....596.619.................*...............676.107..811...*...........................115...........*.........178....
............................=..*...............157.682.......262..*............196......$..........707................14..386...............
.........871............605....721...........................*...867.................685..866.......*.............602...............628.....
......#.....*....413.......@.......380....872................372.......277......277.........*.......166...........@..........656....*....748
.....841..664.......*.422............................945...........%............*.........959.863.........187........299.......*.....887....
.708..............311....+..296*497.....751...639....*..........269..........875....%.........................-.................36..........
.........834..............................@...........708...........................87....298..*471.....$.....463...........................
............+...739..........701........................................779................=.........265..642...............................
......504..........*...............871*314....127..36..639.196..48..................96......../785.........*..854=.....607=...542...........
...73............254.591.........................*..$.....*......*.........35......*...@................150...................-........340..
........224............/....*214...=..........949..............455.........*.......377.88....................823......582.............*.....
.......*.......643.......901........191..267.......293...................194..266.................987.......*........&....+.........545.....
....604...583.....*............*742........*.........*........$..................*..365............*....=...880.55......540.520#............
............*..272.....843..201.....*....&.128..+....433.......563......281*77.540.+.......979&..134....514.......*..............46.........
...966.....67.......................19.934......224..........#....................................................693............*.....525..
....*.........188.....904......*..............................210....*958.........811...............574....965................288..20.$.....
..213.........*...137*.......325.....628..................406......34..............*.......406...$.*.........*.........867..........*.......
...........810............................*.....926.........*..............372.....372.....*...266.716........985......*.............1......
...............399*126.....*.......*...379..729.+........245.........893....-..866.....101.299..........8.544........784....................
954......................63.501.529........-.......695/.................................*..........320....................211.55...533......
............457..........................=.......................375#..........961*......720......*...............542........*.....+...327..
........396...*.476.774.680.189@.438......669............936.......................195.......405.926.213.....254.....*.................*....
...-.......-.......*.....&...........$........22....732.*.......$121.200...............-.......*........*.............522.825..77...........
....272..............#............925.....378*......&....53.............*....605.....329.116..501..=.765......537.680......*..*.........#...
817........109....209...........................690...................573...&............/........48...........*.....*..169...581.......537.
...=..747.............171.70.........990........*..............529.............482.....................383......531.53.............#211.....
......*.....470........*...*.812.664.=.......141.....82...888...*.................@.312....9*860...........529............./...952..........
.....906...*....810...966....*.....*.....................*.......616........327-.....*...............................80.655.................
323......459......@.........185.....894..891..........254.................................938.........262........602*.......................
.............110.........................$......*55..........155..................248*600.....66........*...............*......75..880......
.....459...........928...............................*900.....@.....27............................526....434.402.....840.816.......*........
......*........241....*...70.465...668....110=....905...........252..*..............%..........74.............*.................817...290...
.540...224........*.42......*........*.................705.......*..128...&.758=.512...884.....*..648*.......259.......486.627.......*......
....*..........467................462..321....296*211.*........283......488...........%......796......774.............%.......+.200.87......
...663..............$961..579...........................*...................189..........71................420..57...............*..........
...........617.645...........*........700..886...806.581.610.....132.379.......$......+....-..941$.....................504....589........528
......377.......+.....290...221..768.....*....&....&................*.................556..............132.............*....................
......................+.............*152.448............903.....339.....=.......709............991.......*.............865..................
....-.....$717.............552................40..458....*.....*......365.......-......762.732...*.....690.266.....222............122.......
.414...........496...+.712..*...=....785.........*.......79...884.991................/....*.....844..-........@....*...782...........*627...
.......$........%..560..*...873..739..#........368.991......*.....*.....27..........951..............864.........206...*...878..............
.....231..995...........865................602......*....379.609.935...+......643................952.....@...........884...*................
.............$....726........360..........=.................................................*990.+........959............932................
.....................+.508.....=...194.......*30........./...........487......171...243..709........495.........995.464.......997...........
......292..............$.............*....253.........*.554...........*......../......................*.........*....%......*....*582.446...
...........802.....237.....*32...286.259............132.....236......683.....&.......................705...$855.37.....=...476.........*....
.....418=.............*.664........*..........*11............$.....=.....70.380....138.....416.609..................452........43...156..260
....................20..........512........303.....-................491...*.......*.........*..&..........&962..........*......#........-...
426.646....833...........821....................348.......537...668........92.....295.....620...................147=.753....................
......*.....*..................210.681...................$..........937.......350......................533............................+.....
.65...22..656...#........*44...*.......178*.........446.........655..............*592.....952-.....680..*...........=..305#............704..
...*.............422..835......126.........552.......*....543..........-....444.......995.........=.....771........480.........782..........
............28............983$...........5............953.&.......216..749....=..........-....................232...........................
.....................878................*.........426...............*.........................$........792%..*....898......264...39.........
...480.....674..149+...................740......#....*251..920.......552......................713...........639.......917.........*.........
...+........+...................$951..........*..968.......*............................................750.......479............770.959....
...............424..54*489..+...........14..355...........782...50................900.770..........639.....&.942.....*39.....477........+...
....888.....................412................................*...%123...579...../....&.....315.....#..........*..............*..66........
......*..........................793..402.......*807...854@...115........................=...*...204.......208..928..........121............
...........880=.818......982......*......*...923.......................................809.962...*.........&................................
...957*511.........*436..@......704.......................-......../....84/...369.496..........917.....................464..................
............................812.........785*...............848..506..................*116................=..#...............................
..........694..257..876.....................15.........176.............................................593...168...914.230-.200.........500.
...427...&.....*..........................................*.............=...%....233..616&....299*.................-....................=...
......&......598............571/....60.........897.......911....34....106...713.@.............................933..........288..............
..314...............563...&...........*...........*............*......................198........................*............*591....246...
....*......274.875.....+.114...........105.763..319...................*730.....158.....................487.......505........................
.439..........*......................*........*.......595.190.173..653............*...882.812.....*230..-............522....=.......192.....
................554...825...845...797.572..814.......*.......*............*....167.......*.....581...................-.......330.......#....
.......82......*......$....#.........................318...............326.924......880....288..........*.....44.....................+......
.....-...-....526.........................=981...........959....................*.............*......915.116.*....$...=..............577....
..130..............................@330..............414.*....679........999.344.611.......432..................690....502..................
.............476...#.........................................&.............%...........303.....731.........681..............................
....@791....*....152....397....*.....975............904................225...............*.......$........&.....169.207.....................
..........995...........&...558.857.......141..803.%....-........199.....*......573..63..315................*...........519.................
......................................158*....*........737.........%....399....*..................#47....100................574...#333......
..........56............822..................665............................563..383........................................................";

    [TestMethod]
    public void Day03_1_Test()
    {
        AdventOfCode2023Lib.Day03_1(inputDay03_1).Should().Be(4361);
    }

    [TestMethod]
    public void Day03_1_Final()
    {
        AdventOfCode2023Lib.Day03_1(inputDay03_Final).Should().Be(532445);
    }

    [TestMethod]
    public void Day03_2_Test()
    {
        AdventOfCode2023Lib.Day03_2(inputDay03_1).Should().Be(467835);
    }

    [TestMethod]
    public void Day03_2_Final()
    {
        AdventOfCode2023Lib.Day03_2(inputDay03_Final).Should().Be(79842967);
    }

    #endregion

    #region Day04

    private const string inputDay04_1 = @"Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53
Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19
Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1
Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83
Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36
Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11";
    private const string inputDay04_Final = @"Card   1: 26 36 90  2 75 32  3 21 59 18 | 47 97 83 82 43  7 61 73 57  2 67 31 69 11 44 38 23 52 10 21 45 36 86 49 14
Card   2: 45 10 54 17 15 38 59 96 25 32 | 17 12 77 87 29 70 38 96 15 54 86 64 32 10 28 59 24 45 65 81 42 25 98 14 60
Card   3: 37 31 21 71 80 76 91 77 64 69 | 90 71 91 13  2 40 83 22 45 31 69 53 77 27 97 35  4 55 14  9 52 21 16 19 63
Card   4: 16 82 44 42 51 11 86 14 92 47 | 44 61 81 88 15 11 76 42 17 98 48 83 14 92 99 16 82 86 56 47 10 66 13 22 51
Card   5: 83 84 64 81 97 88 96 59 92 25 | 52 65 98 86 75 48 96 60 56 33 76 81 29 44 97 82 59 64 88 25 23 92 37 84 83
Card   6: 50 51 91 86 25 44 75 23  5 56 | 86 17 56 16 91 75 27 94 39 80 25 71 23 26 12 31 43 45  5 18 50 44 96 51 57
Card   7: 34 14 63 33 87 92 69 67 24 13 | 86 47 31 45  3 32 81 96 21 93 80 25 90 63 79  6 49 91  7 95 62 66 19 24 76
Card   8: 19 67 63 77 62 92 51 49 52  1 | 35  1 94 87 11 82 12 84 49 28 39 96 92 23 34  4 56  5 63 13 77 47 14  9 78
Card   9: 54 14 61 36 10 35 92 34 47 95 | 87 92 95 54  3 47 15 36 90 11  9 84 10 75 45 72 61 88 14 64 35 34 98 46 76
Card  10: 27 59 55 95  4 99  8 48 97  6 | 51 50 48 91 34  4 97 86 27 99 20 95 17  6 80 43 21 60 28 10 89 59 73 55  8
Card  11: 74 46 96 17 62 65 38  4 29  6 | 48 83 42  4 17 35  1 38  6 74 40 95 80 49 46 29 65 62 85 47 96 18 76 36 68
Card  12: 68 12 22 46 33 57 61 86 13 62 | 62 35 20  7 16 78 60 11  9 31 46 34 73 68 77 36 61 66 65 14 26 83 98 95 69
Card  13: 50 14 10  3 83 27 52 84 61 44 | 75 22 56 60 62 36 87 33 85 52  7 95 19 81 10 47 20 73 50 13 46  3 83 37 84
Card  14: 51 42 40 21 29 78 10 31 54 24 | 78 67 10 17 54 99  1 87  8 66 23 56  5 63 92 50 71 47 98  3 73 16 74 42 85
Card  15: 65 68 76  6 40 78 11 60 55 84 | 39 40 59 43 55 69 72 14 94 66 20 80 11 93 64 68 96 34 38 84 67 41 53 89 88
Card  16: 77 95 61 17 74 46 54  3 37 81 |  3 14 41 73 12 75 31 71 24 26 92 74 64 98 89 95 93 19 15 82 91 30 66 81 40
Card  17: 87 11 32 58 43 99  7 79 37 82 | 70 14 67 68 18 29 54 12 15 17 34 71 84 74  4 36 98 42 24 23 38 97 79 81 83
Card  18:  2 70 93 86 50 39 15 76 64  8 | 76 42 75 67 14 39 15 64 45 10 56 12 32  2 93 52  8 68 97 36 79 98 17 37 59
Card  19: 55 53 86 35 88 48 79 56 34 33 | 77 89 45 76 82 23 52 97 62 27  7 38 84 81 99 41 40 70 42 50 21  4 80 12 46
Card  20: 53 21 29 48 42 89 12 34 76 14 | 56 46 69 50 88 85 74 40 66 47 79 77 61  9 67 39 22 63  6 59 54 92 14 51 96
Card  21: 11 87 63 43  5 91 22 45 61 26 | 46 99 43 57 88 75 32 34 91  7 87 15 13 54 66 82  1 10 31 70 24 16  2 90 39
Card  22: 31 89 65 74 38  4 99 40 19  9 | 45 28 54 77  3 42 14 55 41 71 81 84 82 69 64 97 76 48 56 13 23 66 15 30  8
Card  23:  6 59 76 99  9 86  4 84  5 27 | 37 80 51 24 46 72 68 82 89 30 21 55 96  7 91 85 92 93 78 14 70 61  2 11 50
Card  24: 11 37 40 53 70 95 44  3 92 49 | 60 67 54 52 34 93 87 26 74 88  4 91 78 68 17 38 97  7 43 69 64 18 73 15 80
Card  25: 35 52 84 65 30  2 37 89 67 90 | 51 14 25 96 45  4 28 88  8 22 13 66  9 48 82 85 86 54 75 91  1 10 29  5 39
Card  26: 88 84  2 68 47 81  8 11 46 29 | 47 84 98 20 75 63 44 64 15  7 27 53 43 26 68 73  2 91 78 29 46 11 76  8 99
Card  27: 65 94 27 71 54 86 77 47 64 31 | 65  8 27 76 83 64 69 96 78 61  7 11 72 55 41 10 54 93 15 52 90  4 33 94 82
Card  28: 46 89 43 92 93 60 14 34 91 69 | 60 94 46 43 82 53 91 34 92 15 28 55  6 88 57 89 14 67  4 61 36 69  2 93 12
Card  29: 73 54 41 45 29 83 65 70 80 72 | 42 59  6 73 36 87 23 14 47 96 77 72 43 29 70 93 90 50 65 68 56 19 17 63 76
Card  30: 73 18 66  4 96 55 52 59 93 97 | 36 50 90 22 78 96 71 60 87 26 84 74 66 68 55 54 63 73 20 97 10 12 16 76 93
Card  31: 58 42 91 76 86 26 80  5 14 79 |  1 40  4 42 11 13 68 99 10 97 59 76 56 67  5 91 93 26 38 87 80 17 86 33 12
Card  32: 65 29 20 80 13 60 43 18 17 95 | 55 53 72  8 22 45 90 79 81 10 77  5 26 87 52 56 43 30 54 98 93 14 62 74 51
Card  33: 40 81 10 65 18 59  1 68 69 35 | 65 91 69 35 59 48 23 37 33 10 29 11 76 25 55 64 58  9 46 47 83 51 98 68  1
Card  34:  9 87 17 41 81 51 50 20  5 14 | 54 19 81 60 48 90 70 43 44 62 78  3  9  6 87 51  4 47 77 30 82 76 56 13 94
Card  35: 58 71 47  3 59 96 92 30 74  4 |  9 78 30 51 43 82 96 35 48 76 53 52 62 49  4 41 39 93 27 80 87 59 33 34  7
Card  36:  8 45 92 39 66 36 34 69 82 63 | 67 37 24 19 85 46 47 92 74  3 17 97 61 65 83 39 77 34 15 55 75  7 20 28 54
Card  37: 39 59 17 65 89 24 28 87 86 29 |  3 67 73 44 27 68  8 12 32 59  2 50 40 76 62 75 34  5 72 18 52 25 70 90 53
Card  38:  7 91  1 70 12 16 57 78 89 69 | 92 28 56 94 15 44 31 35 51 82 11 52  7 74 62  3 76 93 26  6 19 72 86 30  2
Card  39: 63 43 99 29 91 33 52 96 76 26 | 61 53 42  2 84 73 72 55 49 18 80 34 77 62 43 45 92 50 38 40 89 60 47 69 16
Card  40: 83 91 18 21 48  6 82 85 39 17 | 38 43  7 77 59 40 73  1 49 76 66 64 84 22 53 56 15 42 94 24  2 10 99 70 63
Card  41: 19 74 11 78 71 39 21 58 25 50 | 81 26 33 82 71 58 54  4 19 47 37 73 50 74 99 25 44 39 38 78 21 77 11 88 59
Card  42: 22 15  3 33 62 13 67 18 24 72 | 50  4 86 74 15 38 47 42 89  9 30 87  2 20 33 17 78 45 48 81 62 51 71 35 96
Card  43: 39 42 48 11 23 59 25 54 40 88 |  7 73 32  8  1 60  4 13 14 70 79  3 98 68 76 43 47  6 56 85 92 94 74 62 90
Card  44: 30 16 41 34 89 13  1 53  3 59 | 64 50 55 74 67 78 89 86 63 85 26 28 34 69 59 31 44 56 37 39 20 15 17 71 93
Card  45: 13 57 96 32 69 88 75 15 40 47 | 40 61 32 70 95 29 28 75 87 37 69 57 72 63 15 30 21 38 13 47 20 96 56 76 88
Card  46: 71 28 77 18 39 16 25  1 95 66 | 50 30 39 62 54 25 22 16 24 32 40 41 95 11 64 38 77 14 34 90 86 48  1  4 79
Card  47: 32 31 18 26 43 33 46 39 60 29 | 85 51 41 74 77 14 72 89 65 60 11 92 33 39 18 15 32 95 42 46 94 38 90 68 53
Card  48: 13 47 30  5 40 66 64 51 60 83 | 13 30 84 83 43 40 46  5 98 47 91 86  4 66 23 96 10 92 51 60 93 64 36 71 53
Card  49: 72 99 94 27 31 49 75 36 66 82 | 95  4 14 11 36 89 19 45 50 84 24 72 99 90 82 71 56 16 20 58 39 83 75 49 22
Card  50: 25 81 56  1 64 50 80 79 87 23 | 98 19 25 22 50 24 74 29 51  1 54 39 80 28 23 87 75 56 93 89 55 71  3 65 79
Card  51: 81 10 35 77 13 47 90 24 79 97 | 14 32 77 85 58 17 30 89  8 51 13 76 80 94 79 56 65 43 11  5 19 47 70 90 81
Card  52: 14 34 90 39 44 26 95 17 19 20 | 80 78 93 16 67 15 68 36 98  1 35 45 10 86 65 61 47 26 82  9 69 83 81 23 48
Card  53: 55 75  8 44 62 30 19 97 65 12 | 77 96 15 42 86 84 70 24 68 11 97 69 16 56 66 13 73 74 46 67  2 88 63 50 98
Card  54:  2 69 28 76 77  6 86 74 32 38 | 83 96 73 79 71  8  4 46 63 49 65 16 84 75 26 50 61 37 17 39 36 47 58 14 91
Card  55: 41 89 46 60 37 82 69 52 35 72 | 16 56 63 34 45 59 37  1 29 46 51 75 99 90 76  7 60 57  5 98 62 20 93 50 44
Card  56: 27 11  5 14 81 18 33 36 96 69 | 67 61  6 28 77 63 74 44 60 29 54 93 94 40 83 20 97 66 52 87  2 79 32  1 70
Card  57: 30 91 94 56 18 73 32 88 51 84 | 62 45 54  7 53 96 29 43  3 81 91 80 24 14 46 65 89  4 92 50 71 35 49 47 86
Card  58: 47 55 32 62 21 25 69 60 14 41 | 98 87 10 84 89  4 28 96 72 35 66 31 95 91 76  3 52 45 81 24 97  8  1 27 67
Card  59: 34 10  7 40 92 72  4 44 98 23 | 50 92 98 10  4 17 34 44 65 74 21 64  6 23 40 72 79 86 59 27  7 91 47 63 16
Card  60: 75  7 58 65 17 14 50  8 69 20 | 96 25 69 20 75 50  7  8 64 31 14 17 24 65 93 19 40 62 53 90 34 58 74 85 51
Card  61: 40 93  9 39 71 44 36 80 87 90 | 87 27 25 39 26 36 97 82 79 93 44 15 31 20  2 61 90 55 40 74  1 80  7 95 49
Card  62: 78 91 53 31 29 93 98 99 46 43 | 59 53 28 70 31 37 99  1 82 46 44 60 17 61 43 29 98 93 91  8 42  6 78 32 23
Card  63: 36 20 89 67 86 17 50 29 49 12 | 43 99 83 28 29 94 50 76 82 51 40 47 97 30 20 78 49 72  6 57 46 67 75 68 86
Card  64: 69 24 34 10  2 14 86 38 76  5 | 70 38 34 99 64 10 75 82 58 72  5  2 83 76  9 15 42 81 86 24 59 74 18 69 14
Card  65: 33 69  2 45 25 40 35 48 83 53 | 64 40 33 48 63 96  2 22 53 97 43 69 83 79 20  5 35  9 25 29 74 47 72 99 45
Card  66: 93  1 92 57 71 23 85 51 13 88 | 10 27 92  6 65 28 33 67 53 58 38 13 40 69 90 97 24 50 36 85 54 91 94 30 21
Card  67: 82 25 87 96 97 55 35 90 68 93 | 40 74 21 45 59 82 16 67 79 36 32 28 12 73 81 60 84 54 77 29  7 58 86 34  3
Card  68: 13 22 75 87 19 67 29 51 80 17 | 91 87 16 98 52 24 43 34 19 80 23 21 99 44 27 13 60 42 17 79 67 14  1 31  3
Card  69: 50 35 32 17 92 40 88 41 91 77 | 71 17 41 23 26  5 92 29 55 91 40 83 88 65 51  9 50 53 77 46 54 35 62 32 52
Card  70: 56 61  5 90  8 15  6 46 10 98 | 10 55 82 56 30 72 78 13 91 95 49  6 93 27 74 85 64 62 70  8  9 54 57 45 90
Card  71: 76  2 26 66 56 41 72 70 61 94 | 88 32 97 68 83 37 76 41 36 86  3 84 44  9 24 69  5 95  7 50 35  1 27 77 46
Card  72: 82 38 71 98 60 55 29 73  4  1 | 83 92 69 85 64 97 35 33 20 87 81 71 57 75 66 82 29 19 63 36 23 58 60 93 72
Card  73: 74 70 33 43 58  5 47 18 98 59 | 77 81 75 64 69 92 20  2  1 28 40 32  7 12 57 31 68 36 45 46 61 97 39 66 63
Card  74: 85  6 64 88 46 86  4 25 12 17 | 11 49 38 40 36 46 23 62 84 48 12 60 76 75  9 10 90 35 26 37 69 89  4 17 43
Card  75: 71 52 55 35 87 86 60 27 32 89 | 35 30 73 10 89 98  4 69 22  9 23 17 71 53 87 83 48 86 74 40 21 62 63 85 50
Card  76: 75 66 33 41  3 25 99 98 37 91 | 35 38 12 11 46 40 20 15 94 61 47 79 10 83 24 50 51  2 48 26 63 13 72  4 88
Card  77: 78  8 62 30 92 18 76 36 84 91 |  4 26 82 15 92 94 13 48 33 49 46 60 74 58 81 67 10  2  9 23 70  6 57 53 79
Card  78: 56 55 32 44 13 84 95 85 20 92 |  7 17 87 86 16 60 70 65 74 12  4 18 95  8 19 54 15  6 94 84 82 58 59 28 99
Card  79: 16 14 42 27 10 49 89 65 91 76 | 68 70  1 61 81 71 32 40 51 41 36 31 45 33 18 94 17  2 60 76 74  6 62 79 11
Card  80: 56 78 20 15 58 30 49 75 79 66 | 12 52 96 14 80 34 61  7 40  9 17 47 97  6  2 93 39  3 76 42 43 71 33 67 54
Card  81: 75 44 15 74 17 25 51 28 96 67 | 45 69 89 75  8 67 71 70 46 40 15 96 87 20 28 17 21 42 85 68 44 18 74 59 51
Card  82: 74 29 44 13 94 22 40 80 36 27 | 55 51 74 40 77 36 49 87 43 13 46 62 23 38 90 30 39 57 70  1 80 22 91 32 89
Card  83: 87 21 17 14 49 92 19  1 77 36 | 67 36 31 74 87 13  1 21 35 97 99 52 19 92  9 77 51 49 89 72 14 26 56 17 90
Card  84:  2 60  7 46 57 31 68 83 25  5 | 42 72 20 38 88 35 73 98 92 89 41 90 65 81 96 21 50 62 87 36 43 33  8 66 55
Card  85: 38 43 61 78 57 48 82 80  3 26 | 25 17 61 94 50 69  5 26 39 85 76 58 80  8 33 11 55 38 79 60 82 93 84 20 86
Card  86: 17 36 14 77 98 99 33 38 34  4 | 17 97 98 30 38 65 16 43 28 85 77 36 83 88 29 18 60 26 14 33 80 78 99 34  4
Card  87: 42 52 68 76 78 48 36 50 65 44 | 21 23 42 68 13 43 63 36 33 67  8 66 70 90 48  1 65 50 34  7 69 82 76 78 44
Card  88: 68 67 15 30 92 38 96 63 75 44 | 59 30 83  6 48 42 35 28 46 34 92 44 49 78 43 27 47 75 15 33 62 37  3 68 60
Card  89: 12 46 88 26 86 43 52 83 29 92 |  4 29 60 78 25 43 15 74 73 99 83 86 59 27 96 44 38 48  6 37 52 85 42 41 46
Card  90: 95 71 59 29 13 83 90 57  7 94 | 71 19 43 13 68 84 51 29 16 31 45 94 57 92  7 90 20 55 98 36 64 83 59 10 95
Card  91: 16 74 55 79 95 25 84 61 67 14 | 67 44 80 79 62 81 25 84 61 35 72 78 10 93 14 95 16 45 85 66 74 47  8 29 53
Card  92: 41 74 92 35 88 76  9 79 71 53 | 51 88 44 71 81 49 36 97 35 46 33 62 18  9 85 98 79 76 53 47 41 89 92 63 94
Card  93: 71 11 27 69 65 21 23 25 40 81 | 90 96 34 21 11 55 20 76 44 49 60 75 71 98 27 40 58 63 43 81 18 59 33 88 47
Card  94:  4 39  9 70 63 75 14 99 29 25 | 99 77 91 19 30 94 25 26  1 80 73 32 48 10 61  4  7 31 75 39 70 36 63 51 57
Card  95: 30 24 19 73 42 89 47 66 61 13 | 30 86 52 37 61 25 65 33 32 41 44 92 10 95 59 34 93 39 43 14 73 74 82 13 94
Card  96: 51  3  7 37 96 54  9 83 69 95 | 95 61 28 83 69 22 31 54 51 50 25 29 89 27  4 14 49  3 53  6 59  7 21 30 79
Card  97: 67  5 91 27 33  4 99 15 19 85 | 33 84 51 65 15 67 93 47 94 35 80 11 45 86 69 82 55 85 63 12 29 68 76 61 41
Card  98: 60 64 34 61 95 94 36  2 11 75 | 71 60 39 12 11 51  7 88 64 54  5 90 84 50 26 22 42 36 92 53 67 28 76 58 38
Card  99: 40 77 57 46 19 55 28 31 11 70 | 62 12 45 46 49 32 94 93 13  7 29 66 70 99 37 63 30 52  4 84 54 36  2 11 33
Card 100: 15 18 10 32 26 89 17 78 85 64 | 14 54 15 11 75 45 91 83 88 86 60 62 92  8 29 19 58 79 59 31 93 66 55 46 13
Card 101: 15 44  6 92 88  7 24 20 28 83 | 12 41 95 92 61 16 84 29 31 89 85 97 79 63 54 78 60 27 11 64 72 23 94 52 14
Card 102: 87 56 58  2 25 57 85 83 95 24 | 51 42 58 71 44 62 19 43 27 45  9 13 59 28 93 99  8 31 38 65 32 54 48 97 90
Card 103: 32 37 48 65 94 71 83 31 24 80 | 47 76 28 74 99 46 91 78 21 34 40 20 11 35 88 14 16 55 87 97 52 36 56 90 81
Card 104:  5 35 42 73 55 13 59 81 33  9 | 50 12 81 85 35 82 62 13 73 58 93 59  9 80 68  4 18  7 86  5 33 16 55 65 42
Card 105: 44 69  1 73 91 24 94 64 31 77 | 34 77 39 94 41  9 69 52 95 17 31 74 98 73 42 44 67  1 36 50 21 91 35 64 24
Card 106: 49 69 38 10 46 92 35 50 15 93 | 89 69 27 24 10 46 35 32 15 81 38 67 49 58 91 29 93 92 57 70 68 82 50 86 90
Card 107: 92 57 65 15 23 45 96 56 88 25 | 92 25 15 31 57 56 64 41 87 30 23 78 38 45 28 10 65 71 96 88 27  3 69 91 73
Card 108: 31  1 94 61 10 45 34 11 41 66 |  2 66 38 78 57 88 19 46 35 23 36 59 34 61 10 96 41 45 81  1 94 63 28 12 76
Card 109: 16 72 48 78 77 27 12 36  7 42 | 22 99 23 36 13 53  2 25 72  1 47 48 14 49 69  3 93 44 78 87 38 55 60 52 90
Card 110:  6 80 47 92 32 83 37 53  4 87 | 92  6 41  4 20 91 81 83 40 70  7 87 19 73 63 37 18 47 99 53 80 32 66 45 39
Card 111:  9 72 17 89 28 68 34 63 76 81 | 80 70 22 36 23 61 59  7 53 43 45 67  3 60  6 89 79 95 56 85 31 98 65 39 48
Card 112: 10 23  9 78 98  3 27  6 84 60 | 16 68 84 10 22 50 87  9  5 23 27 74 21 98  3  2 60 85 73  1 26 83  6 89 78
Card 113: 14 90 59 66 86  7 44 10 40 69 | 91 87 14 59 29 40 56 45 11 66 15 90 48 24 62 69 44 79 20 98 76 10 86  7 43
Card 114: 31 90 75 12 34 60 39 74 24  2 | 56 52 85 40  1 14 80 60 42 84 75 18  6 90 76 25 44 74 28 34 13 12 54 48  7
Card 115: 67 42 11 91 53 57 98 17 95 50 | 74 45 25 98 57 66 67 77 69 95 87 79 83 39 96 84 42 91 21  3 53 17 63 50 11
Card 116: 66 36  5 11 33 51 30 67 38  3 | 50 86 36 76 33 77 30 51 11 67 38 26 43 66 39 69 17 90 21  3 16 56 62  5 73
Card 117: 53 34 69  9 10 61 18 23 93 14 | 44  9 69  2 90 14 53 23 21 92 49 72 31 61 46 10 27 70 57 38 18 93 34 67 11
Card 118: 83 89 94 55 65 36 20 79 53 14 | 36 65 41  8 49 29 99 83 94  5 62 78 53 20 68 66 14 89  4 74 48 81 77 52 55
Card 119: 82 69 85 60  9 13 16  3 18 44 | 82 55 85  3  5 80 43 11 13 86 16 31 56 70 17 46 79 69 60 44 95 81 45 49 93
Card 120: 35 53  9 78 73 55 20 64 13 62 |  9 20  3 84 35 71 22 86  8 64 58 82 88 51 54 13 38 68  5 77 81 56 21 74 55
Card 121: 61 34 85 77 66 87 91 49 15 36 | 59 49 46 70 10 94 93 87 36  3 44 66 24 61 95 83 91 75 89 60 81 57 41 85 74
Card 122: 22 90 71 49 34  4 56 74 42  3 | 21 52 19 53 79 34 56 71 95  5 91 14  4 40 78 96 61 42 57 47 73 50 10 74 87
Card 123: 87 49 40 25 31  4 20 48  1 76 | 12  6 43 69 48  2  9 24 95 65 47 57  4 91 94 39 16 62 68  8 23 42 38 59 78
Card 124: 63 38 94 44 69 76 33 89 47 32 |  8 19 96 98 68 24 54 31 28 67 57 73 45 70 64 22 65 50 34 80  6  4 10 78 90
Card 125:  4 48 65 10 93 80 26 23 90 12 | 64 32 40 87 58  3 13 18 86 60 66 71 74  9 61 43 50 99 88 52 95 46 37 22 67
Card 126: 90 71 53 57  5 24  6  3 52  8 | 96 33 13 70 44 27 87 89 81 63 65  8 66 47 31 92 40 53  7 88 99 19 64 38 79
Card 127: 89 68 48 98 32 22 73 79 53 93 | 75 30 35 15 96 64 19  4 14 66 88 85 33 11 43 82 25  1 61 91 94 45  6 78 77
Card 128: 15 39 76 95  5 70  9 23  4 65 | 64 58 90 54 46 42 68 29 11 38 20 92 87 44 98 83 99 27 67 22 13  6 14 43 55
Card 129: 45 83 47 63 64 38 15 95  6 48 | 49 91  6 20 64 56 52 28 55  5 15 54 61 11 71 95 53 57  8 75 27 98 92 13 81
Card 130: 37 14 56 22  7  1  9 76 83 91 | 56 53  1 36 74 37  9 73 70 91 22 77 83 44 68 97 54 39 76  7 65 55 14 34 38
Card 131: 23 92 82 24 86 78 31 98 68 48 | 83 29 28 54 65 47 92 67 94 48 89 49 24  4 59 40 41 82 86 64 38 98 78 66 68
Card 132:  9 63 36 66 29 97 90 20 81 46 | 10 40 43 82  4  9 37 87  3 27 28 54 65  5 50 80  8 31 73 26 88 96 74 23 57
Card 133: 17 48 12 31 13 44 57 45 40 88 | 56 80 55 26  8 16 22 70 13 45 78  7  4 40 10 71 34 32 59 35 69 82 47 88 46
Card 134: 91 87 65  7 49 67 17 60  9 78 | 50 35 40 25 74 62 29 80 21 93 92 52 39 81 51  8 47 65  4 89 83  6 88 87 43
Card 135: 35 87 16  9 34 80 15 81 83 61 | 46 40  8 93 89 67 86 35 71  9 76 95 49 26 22 28 87 90 64 34 79 27 32 59 23
Card 136: 23  1 83 65 67 46 40 97 71 55 | 86  8 79 95  2 59 20 60 31 11 42 97 62 12 67 80 19 55 81 33 13 87 57  9 23
Card 137: 23 99 91  8 79 45 29  3 42 27 | 85 45 65 82 36 76 29 48  8 78 54 79 57 34 70 52  3 96 19 86 12 91 51 59 66
Card 138: 47 48 85 73 89 61 98 39 36  2 | 83 50  1 63 71 30 76 11 93 82 60  4 78 56 66 25 75 33 51 57 28 24 67 74 58
Card 139: 40 41 96 36 71 97 74 78  9 83 | 41 73 51 70 76 22 23 63 56 58 26 91 47 37 88 80 18 67 95 33 11 60 34  7 94
Card 140: 98 32 46 64 18 95 27 65 74 41 | 89 20 42 40 58 84 48 76 67 12 73 44 23 92 90 70 81 71 85 11 83 59 78 22  9
Card 141: 34 18 67 74 52 35 31 27 14 54 | 92 44 48 73 14 51 98 54 88  5 70 65 80 66 84 56  7 40 39 71 94 86 26 25 11
Card 142: 57 53 93 13  4 96 83 23 74 90 | 82 43 42 40 38 87 81 58 44 71 59 50  7  9 30 98 66 80 85 29  1 84 20 26 72
Card 143: 47  3 32 53 72 82 44 64 85 24 |  2 71 98 94 62 23 87 68 93 86 70 96 19 84 74 15 95 42 29 90  6 54 67 30 61
Card 144: 74 46  9 94 60 86 56 40 34 57 | 66 55 16 95  5 25 75 90 47 76 54 93 61 23 37 89 64 48 42 30 18 31  3 97 27
Card 145: 57 25 17 78  1 63 31  3 65 23 | 39 95 13 65  3 27 17 85 56 47 10  8 63 51 23 25 40 22 54 78 81 62 90  4 50
Card 146: 54 71  5 68 25 76 33 31 32 64 | 99 75 87 61 32 91 47 71 11 51 43 36 33 83  3 63 35 42 16 31 81 28 86 22 90
Card 147: 22 98 86 67 26 72 31 52 93 20 | 87 42 20 49 43 35 27 52 56 86 40 22 29 59 76 26  9 93 30 58 67 31 72 33 98
Card 148: 47 81 86  1 87 63 16 58 98 26 | 34 15  7 39 47 86 21 14 81 49 87 43 91 24 73 63 18 98 37 29 77 53 67 26 19
Card 149: 24 21 62 66 80 31 50 23 13 54 | 47  6 13 90 54 49 66 74 62 34  4 95 23 55 50 45 18 59 61 21 26 75 39 80 24
Card 150: 14 97  9 69 44 64 63 22  8 89 | 71 65 32 59 28 43 97 48  6 70 45 75 63 99 60 39 20 78 95 47 55  1 74 58 13
Card 151: 93 73 94 83 23 50 68 40 18 13 | 76 70 83  7  4 23 82 29 78 40 93 77 66 94 92 68 18  2 15 49 17 39 37 35 64
Card 152: 73  6 44 81  1 39 61 34  7 23 | 32 81 85 42 23 40 97 74 55 46 39  2 79 86 91  3 37 33 76 58 77 88 75 12 53
Card 153: 15 19 22 66  3 50 77 97 21 62 | 66 59 27 78  6 28 54 13 32 70 23 51 48 50 17 43 42 21 22 34 16 64  3 37 74
Card 154: 10 17 93 15 92  4 22  2 44 88 | 60 69 90 85 19 13 88 11 84 39 68 33 14 27 95  2 53 87 66 82 74 36 41 42 46
Card 155: 74 88 14 39 78 54 60 75 11 65 | 64 14 66 16 18 81 20 36  3 82  8 62 34 87 43 53 80 96 59 39 78  5 40 13 21
Card 156: 25  5 87 20 51 57 61 39 16 83 | 37 63 60 79 83 52 81 99 92 26 70 76 56  8 73 98  5 48  1 46 16 86 28 12 78
Card 157: 45  7 33 97 91 59 10 77  2 82 | 98 10  1 28  4 37 69 92 99 58 40 42 34 38 26 81  3 18 84 45 31 20 55 36 44
Card 158: 98 33 35 10 56 43 60 68 25 62 | 61 89 80 40  2 26  3 13 57 10 96 71 86 27 78 87 59 37 45 75 79 46 49 36 66
Card 159: 12 31 72 74 90 88 58 73 25  9 | 51 71 23 44  5 34 82 33 55 49 68 39 20 93 13 97 81 14  2 91 76 75 50 95  7
Card 160: 38 23 46  5 85 22 26 81 91 93 | 85 38 22 58 19  3 89 35 84 46 18 53 95 91 47 93 99 33 81 68 57 49 80 71 23
Card 161: 57 14 48 68 72 81 93 61 43 40 |  6  5 47 59 11 81 13 38 52 26 91 22 57 55 35 19 61  2 29 93 14 74 53 45 60
Card 162: 20 52  9 61 26 94 11 84 28 37 | 39  9 88 48 73 14 24 29 28 37 31 27 95 79 98 26 45 11 96 68 47 58 35 62 52
Card 163: 11 42 60 15 27 43 13 17 72 98 | 12 74 81 37 95 20 86 42 72 79 66 89 62 63 38 73 65 82  8 28 50 70 78 15 94
Card 164: 88 38 30  3 48 17 19 68 73  2 | 13 71 34 83 40 38 59 12 73  2 91 52 60 19 87 84  1 82 65  3  8 99 80 79 70
Card 165: 22 62 51 13 76 17 26 41 46 34 | 93 50 94 18 84 39 48 75 59  3 44 67 37 32 55 82 79 14  7 86 61 27 31 74 42
Card 166: 27 80 73 77 72 18 83 97 53  3 |  6 74 34 22 75 60 99 17 47 12 29 64 48 67 15 14 63 13 19 49  5 89 42  9 11
Card 167: 14 31 99 33 53 52 98 95 49 73 | 95 92 60 18 19 39 90 31 10 58  7  6 59 51 73 22 45 49  4 21 67 76 78 56 20
Card 168: 11 78 93 57 58 47 40 22 23 85 |  6 27 66 43 57  2 90 49 25 60 99 19 36 22 47 80  1 32 21 87 98 58 93  9 76
Card 169: 99 40 75 47 22 83 41 50 18 51 | 94 74 86 14 12  5 78 61 89 17  8 83 30 90 51 87 53 43 41 27 13 92 26 49 76
Card 170: 23 16 36 32 91 52 73 53 18 83 | 90 76 24 97 95 62 39 70  3 52 63 30 19 75 96 82  9 71 81 64 22 84 99 35 21
Card 171: 38 27 53 94 16 71 18  6 83 17 | 76  3 78 23 31 19 50 22 57 97 39 35 56 51 83 94 55 85  1  5 12 43 86 58 46
Card 172: 45 79 25 86 56 50 20 18 97 52 | 40 85 90 28 97 43  4  3 22 76 21 61 16 62 95 29 83 44 15 12 56 34 53 36 93
Card 173:  1 79 49 77 62 33 84 76  7 50 | 29  6 42 56 67 47 94 25 97 48 86 43  3 18 51 21 93 16 95 14 15 82 71 87 75
Card 174: 83 64 11 39 24 97 35 54 27 60 | 22 16 31 92 42 94 72 62 58  5 69  8 28 33 89 47 23 52 90 57 68 80  9 96  7
Card 175: 87 10 42 65 40 51 31 45 48 89 | 75 37 60 71 76 92 10 29 14 63 81 34 94 88 32 91  6 82 79 90 53 89 68 49 26
Card 176: 96 83 15 50 17 16 81 85 11 35 | 31 17  8 30 33 47 11 15 41 73 99 40 70 48 91 26 96 60 39 95 52 59 45 23 50
Card 177: 64 51 20 97 68 69 57 58 34 12 | 54 82 32 79 89 70 47 52 16 36 83 10 49  8 18 94 73 77 48 42 19 98 55 75 80
Card 178: 36  1 53 62 73 77 52 59 51  3 | 59 35 68  1 45 77  4 79 83 16 36 63 99 53 52  3 73 51 13 89 84 32 64 33 62
Card 179: 30 70 61  7 29 52 97 81 65 59 | 48  5 42 71 88 89 93 64 37 28 26 25 90 94 92 21 50  6 19 33 68 66 78  1 15
Card 180: 66  3 33 16 57 41 91 83 48 68 | 58 68 33 80 42 13 69 78 16 83 18 41 34 35 79 48 66 62 86 90  2  6 96 57 91
Card 181: 86 94 43 29 75 78 42 95 13 10 | 42 88 43 13 60 52 47 86 87 59 95 72  8 23 82  2 69 61 14 71 94 90 30 85 51
Card 182: 73 90 84 14 52 15 98 43  3 23 | 84  8 11 64 83 62 77 18 53 81 19 47  1 79 99 41 40 74 93 89 20 72 49 26 38
Card 183: 24 78 51 40 92 66 77 39 97 68 | 38 70 63  5 19 21 95 73 64 14 55 80 23 22 77 65 74 97 37 26 82 83  9 52 60
Card 184: 98 12 62 53 69 27 84 64 91 94 | 19  9 90 98 43 26  7 12 68 16 10 45 20 23  4 63  3 38 77  6 27  8 91 70 60
Card 185: 32 37  2 76 75 62 39 33 12 13 | 11 29 49 77 50 97 65 87 25 91 10 21 15 82 95 99 80 71 54 42 48 78 72 63 34
Card 186: 55 49 21 41 83 40 29 51 54 57 | 20 88 52 62 85 90 25 45 54 58 72 91 98 14 13 28 74 92 31  8 42  3 26 11 59
Card 187: 95 43 56 46 98 96 55 31 28 50 | 23  5 13 35 95 37  1 89 76 45 68 73 52 15 26  3 38 36 99 51 80  8 63 77 28
Card 188: 84 71 30 79  6 13 57  3 63 55 | 46 45 43 26 48 47 37 35 88 13 59  9 95 86 49 98 64 62 54 44 22 92 25  3 15
Card 189: 56 94 93 30 27 53 85 58  4 91 | 86 70  1 96 60 92 66 33  9 50 78 41 67 55  7 28 89 31 14 19 76 42 71 82 63
Card 190: 17 27 42 70 11 38 47 58 92 88 | 73 15 86 13 25 64 58  4 61 95 36 41 94 17 72 90 22  6 56 98 35 45 60 19 33
Card 191: 19 96 44 57 88 39  7 67 85 89 | 49 31 15 98 77 14 43 59 85  2 79 71 69 81 95 93 33 66 25 87 65 13 62 46 91
Card 192: 29 77 54 66 79  7 88 72 99 35 | 50 94 48 18 60 56 74 59 97  5 87  8 70 93 81 27 14 57 25 22 71 63 83 44 15";

    [TestMethod]
    public void Day04_1_Test()
    {
        AdventOfCode2023Lib.Day04_1(inputDay04_1).Should().Be(13);
    }

    [TestMethod]
    public void Day04_1_Final()
    {
        AdventOfCode2023Lib.Day04_1(inputDay04_Final).Should().Be(21213);
    }

    [TestMethod]
    public void Day04_2_Test()
    {
        AdventOfCode2023Lib.Day04_2(inputDay04_1).Should().Be(30);
    }


    [TestMethod]
    public void Day04_2_Final()
    {
        AdventOfCode2023Lib.Day04_2(inputDay04_Final).Should().Be(8549735);
    }

    #endregion

    #region Day05
    private const string inputDay05_1 = @"seeds: 79 14 55 13

seed-to-soil map:
50 98 2
52 50 48

soil-to-fertilizer map:
0 15 37
37 52 2
39 0 15

fertilizer-to-water map:
49 53 8
0 11 42
42 0 7
57 7 4

water-to-light map:
88 18 7
18 25 70

light-to-temperature map:
45 77 23
81 45 19
68 64 13

temperature-to-humidity map:
0 69 1
1 0 69

humidity-to-location map:
60 56 37
56 93 4";

    [TestMethod]
    public void Day05_1_Test()
    {
        AdventOfCode2023Lib.Day05_1(inputDay05_1).Should().Be(35);
    }

    #endregion
}



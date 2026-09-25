namespace SunamoEmoticons;

/// <summary>
/// Contains text representations of various emoticons grouped by emotion type.
/// All fields must be internal due to object.GetFields() reflection usage.
/// </summary>
internal class Emoticons
{
    /// <summary>
    /// Happy face emoticons.
    /// Note: Pattern :3 conflicts with time format 10:30
    /// </summary>
    internal string HappyFace = @":‑)
:)	:-]
:]	:-3
:->
:>	8-)
8)	:-}
:}	:o)	:c)	:^)
=]
=)
:‑D
:D	8‑D
8D	x‑D
xD	X‑D
XD
=D
=3	B^D";

    /// <summary>
    /// Frown, sad, angry, and pouting emoticons.
    /// </summary>
    internal string FrownSadAngryPouting = @":‑(
:(	:‑c
:c	:‑<
:<	:‑[
:[	:-||
>:[
:{
:@
>:(";

    /// <summary>
    /// Crying emoticons.
    /// </summary>
    internal string Crying = @":'‑(
:'(";

    /// <summary>
    /// Tears of happiness emoticons.
    /// </summary>
    internal string TearsOfHappiness = @":'‑)
:')";

    /// <summary>
    /// Horror, disgust, sadness, great dismay emoticons.
    /// </summary>
    internal string HorrorDisgustSadnessGreatDismay = @":‑O
:O	:‑o
:o	:-0	8‑0
>:O";

    /// <summary>
    /// Kiss emoticons.
    /// </summary>
    internal string Kiss = @":-*
:*
:×";

    /// <summary>
    /// Wink and smirk emoticons.
    /// </summary>
    internal string WinkSmirk = @";‑)
;)	*-)
*)	;‑]
;]	;^)	:‑,
;D";

    /// <summary>
    /// Tongue sticking out, cheeky, playful emoticons.
    /// Note: XP, xp conflicts with Windows XP operating system name
    /// </summary>
    internal string TongueStickingOutCheekyPlayful = @":‑P
:P	X‑P
x‑p
:‑p
:p	:‑Þ
:Þ	:‑þ
:þ	:‑b
:b
d:
=p	>:P";

    /// <summary>
    /// Skeptical, annoyed, undecided, uneasy, hesitant emoticons.
    /// Note: :/ conflicts with http://
    /// Note: :L conflicts with :Linux
    /// </summary>
    internal string SkepticalAnnoyedUndecidedUneasyHesitant = @":‑/
:‑.	>:\	>:/	:\	=/	=\		=L	:S";

    /// <summary>
    /// Indecision emoticons.
    /// </summary>
    internal string Indecision = @":‑|
:|";

    /// <summary>
    /// Embarrassed and blushing emoticons.
    /// </summary>
    internal string EmbarrassedBlushing = @":$	://)
://3";

    /// <summary>
    /// Tongue-tied emoticons.
    /// </summary>
    internal string TongueTied = @":‑X
:X	:‑#
:#	:‑&
:&";

    /// <summary>
    /// Angel and saint emoticons.
    /// Note: Pattern 0:3 conflicts with time format 10:30
    /// </summary>
    internal string AngelSaint = @"O:‑)
O:)	0:‑3
0:‑)
0:)	0;^)";

    /// <summary>
    /// Evil emoticons.
    /// </summary>
    internal string Evil = @">:‑)
>:)	}:‑)
}:)	3:‑)
3:)
>;)	>:3
>;3";

    /// <summary>
    /// Tongue-in-cheek emoticon.
    /// </summary>
    internal string TongueInCheek = ":‑J";

    /// <summary>
    /// Partied all night emoticon.
    /// </summary>
    internal string PartiedAllNight = "#‑)";

    /// <summary>
    /// Drunk emoticons.
    /// </summary>
    internal string Drunk = @"%‑)
%)";

    /// <summary>
    /// Being sick emoticons.
    /// </summary>
    internal string BeingSick = @":‑###..
:###..";

    /// <summary>
    /// Dunce-like emoticon.
    /// </summary>
    internal string DunceLike = @"<:‑|";

    /// <summary>
    /// Disbelief emoticons.
    /// </summary>
    internal string Disbelief = "',:-|	',:-l";
}
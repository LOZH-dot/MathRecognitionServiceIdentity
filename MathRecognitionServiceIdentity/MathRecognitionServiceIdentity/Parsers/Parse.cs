
using System.Text.Json.Serialization;
using System.Text.Json;

namespace MathRecognitionServiceIdentity.Parsers
{
    public class Parse
    {
        Dictionary<string, ParseClasses> _tokens = new Dictionary<string, ParseClasses>();


        public Parse() { FillTokens(); }

        private void FillTokens()
        {
            _tokens.Add("!", ParseClasses.exclamationMark);
            _tokens.Add("(", ParseClasses.openingBracket);
            _tokens.Add(")", ParseClasses.closingBracket);
            _tokens.Add("+", ParseClasses.plus);
            _tokens.Add(",", ParseClasses.comma);
            _tokens.Add("-", ParseClasses.minus);
            _tokens.Add("0", ParseClasses.zero);
            _tokens.Add("1", ParseClasses.one);
            _tokens.Add("2", ParseClasses.two);
            _tokens.Add("3", ParseClasses.three);
            _tokens.Add("4", ParseClasses.four);
            _tokens.Add("5", ParseClasses.five);
            _tokens.Add("6", ParseClasses.six);
            _tokens.Add("7", ParseClasses.seven);
            _tokens.Add("8", ParseClasses.eight);
            _tokens.Add("9", ParseClasses.nine);
            _tokens.Add("=", ParseClasses.equally);
            _tokens.Add("A", ParseClasses.A);
            _tokens.Add("C", ParseClasses.C);
            _tokens.Add("Delta", ParseClasses.delta);
            _tokens.Add("G", ParseClasses.G);
            _tokens.Add("H", ParseClasses.H);
            _tokens.Add("M", ParseClasses.M);
            _tokens.Add("N", ParseClasses.N);
            _tokens.Add("R", ParseClasses.R);
            _tokens.Add("S", ParseClasses.S);
            _tokens.Add("T", ParseClasses.T);
            _tokens.Add("X", ParseClasses.X);
            _tokens.Add("[", ParseClasses.openingSquareBracket);
            _tokens.Add("]", ParseClasses.closingSquareBracket);
            _tokens.Add("alpha", ParseClasses.alpha);
            _tokens.Add("ascii_124", ParseClasses.ascii_124);
            _tokens.Add("b", ParseClasses.b);
            _tokens.Add("beta", ParseClasses.beta);
            _tokens.Add("cos", ParseClasses.cos);
            _tokens.Add("d", ParseClasses.d);
            _tokens.Add("div", ParseClasses.div);
            _tokens.Add("e", ParseClasses.e);
            _tokens.Add("exists", ParseClasses.exists);
            _tokens.Add("f", ParseClasses.f);
            _tokens.Add("forall", ParseClasses.forall);
            _tokens.Add("forward_slash", ParseClasses.forwardSlash);
            _tokens.Add("gamma", ParseClasses.gamma);
            _tokens.Add("geq", ParseClasses.geq);
            _tokens.Add("gt", ParseClasses.gt);
            _tokens.Add("i", ParseClasses.i);
            _tokens.Add("in", ParseClasses.belongs);
            _tokens.Add("infty", ParseClasses.infinity);
            _tokens.Add("int", ParseClasses.integral);
            _tokens.Add("j", ParseClasses.j);
            _tokens.Add("k", ParseClasses.k);
            _tokens.Add("l", ParseClasses.l);
            _tokens.Add("lambda", ParseClasses.lambda);
            _tokens.Add("ldots", ParseClasses.ldots);
            _tokens.Add("leq", ParseClasses.leq);
            _tokens.Add("lim", ParseClasses.lim);
            _tokens.Add("log", ParseClasses.log);
            _tokens.Add("lt", ParseClasses.lt);
            _tokens.Add("mu", ParseClasses.mu);
            _tokens.Add("neq", ParseClasses.neq);
            _tokens.Add("o", ParseClasses.o);
            _tokens.Add("p", ParseClasses.p);
            _tokens.Add("phi", ParseClasses.phi);
            _tokens.Add("pi", ParseClasses.pi);
            _tokens.Add("pm", ParseClasses.pm);
            _tokens.Add("prime", ParseClasses.prime);
            _tokens.Add("q", ParseClasses.q);
            _tokens.Add("rightarrow", ParseClasses.rightarrow);
            _tokens.Add("sigma", ParseClasses.sigma);
            _tokens.Add("sin", ParseClasses.sin);
            _tokens.Add("sqrt", ParseClasses.sqrt);
            _tokens.Add("sum", ParseClasses.sum);
            _tokens.Add("tan", ParseClasses.tan);
            _tokens.Add("theta", ParseClasses.theta);
            _tokens.Add("times", ParseClasses.times);
            _tokens.Add("u", ParseClasses.u);
            _tokens.Add("v", ParseClasses.v);
            _tokens.Add("w", ParseClasses.w);
            _tokens.Add("y", ParseClasses.y);
            _tokens.Add("z", ParseClasses.z);
            _tokens.Add("{", ParseClasses.openingCurlyBrace);
            _tokens.Add("}", ParseClasses.closingCurlyBrace);
            _tokens.Add("", ParseClasses.none);
        }

        public string JSONParse(string str)
        {
            string[] inputClasses = str.Split(' ');
            List<string> serialize = new List<string>();

            foreach (var sym in inputClasses)
            {
                ParseClasses _class = _tokens[sym];

                switch (_class)
                {
                    case ParseClasses.minus:
                        serialize.Add("-");
                        break;
                    case ParseClasses.exclamationMark:
                        serialize.Add("!");
                        break;
                    case ParseClasses.openingBracket:
                        serialize.Add("(");
                        break;
                    case ParseClasses.closingBracket:
                        serialize.Add(")");
                        break;
                    case ParseClasses.comma:
                        serialize.Add(",");
                        break;
                    case ParseClasses.openingSquareBracket:
                        serialize.Add("[");
                        break;
                    case ParseClasses.closingSquareBracket:
                        serialize.Add("]");
                        break;
                    case ParseClasses.openingCurlyBrace:
                        serialize.Add("{");
                        break;
                    case ParseClasses.closingCurlyBrace:
                        serialize.Add("}");
                        break;
                    case ParseClasses.plus:
                        serialize.Add("+");
                        break;
                    case ParseClasses.equally:
                        serialize.Add("=");
                        break;
                    case ParseClasses.zero:
                        serialize.Add("0");
                        break;
                    case ParseClasses.one:
                        serialize.Add("1");
                        break;
                    case ParseClasses.two:
                        serialize.Add("2");
                        break;
                    case ParseClasses.three:
                        serialize.Add("3");
                        break;
                    case ParseClasses.four:
                        serialize.Add("4");
                        break;
                    case ParseClasses.five:
                        serialize.Add("5");
                        break;
                    case ParseClasses.six:
                        serialize.Add("6");
                        break;
                    case ParseClasses.seven:
                        serialize.Add("7");
                        break;
                    case ParseClasses.eight:
                        serialize.Add("8");
                        break;
                    case ParseClasses.nine:
                        serialize.Add("9");
                        break;
                    case ParseClasses.A:
                        serialize.Add("A");
                        break;
                    case ParseClasses.alpha:
                        serialize.Add("alpha");
                        break;
                    case ParseClasses.ascii_124:
                        serialize.Add("|");
                        break;
                    case ParseClasses.b:
                        serialize.Add("b");
                        break;
                    case ParseClasses.beta:
                        serialize.Add("beta");
                        break;
                    case ParseClasses.C:
                        serialize.Add("C");
                        break;
                    case ParseClasses.cos:
                        serialize.Add("cos");
                        break;
                    case ParseClasses.d:
                        serialize.Add("d");
                        break;
                    case ParseClasses.delta:
                        serialize.Add("delta");
                        break;
                    case ParseClasses.div:
                        serialize.Add("div");
                        break;
                    case ParseClasses.e:
                        serialize.Add("e");
                        break;
                    case ParseClasses.exists:
                        serialize.Add("exists");
                        break;
                    case ParseClasses.f:
                        serialize.Add("f");
                        break;
                    case ParseClasses.forall:
                        serialize.Add("forall");
                        break;
                    case ParseClasses.forwardSlash:
                        serialize.Add("/");
                        break;
                    case ParseClasses.G:
                        serialize.Add("G");
                        break;
                    case ParseClasses.gamma:
                        serialize.Add("gamma");
                        break;
                    case ParseClasses.geq:
                        serialize.Add("geq");
                        break;
                    case ParseClasses.gt:
                        serialize.Add(">");
                        break;
                    case ParseClasses.H:
                        serialize.Add("H");
                        break;
                    case ParseClasses.i:
                        serialize.Add("i");
                        break;
                    case ParseClasses.belongs:
                        serialize.Add("in");
                        break;
                    case ParseClasses.infinity:
                        serialize.Add("infty");
                        break;
                    case ParseClasses.integral:
                        serialize.Add("integral");
                        break;
                    case ParseClasses.j:
                        serialize.Add("j");
                        break;
                    case ParseClasses.k:
                        serialize.Add("k");
                        break;
                    case ParseClasses.l:
                        serialize.Add("l");
                        break;
                    case ParseClasses.lambda:
                        serialize.Add("lambda");
                        break;
                    case ParseClasses.ldots:
                        serialize.Add("ldots");
                        break;
                    case ParseClasses.leq:
                        serialize.Add("leq");
                        break;
                    case ParseClasses.lim:
                        serialize.Add("lim");
                        break;
                    case ParseClasses.log:
                        serialize.Add("log");
                        break;
                    case ParseClasses.lt:
                        serialize.Add("<");
                        break;
                    case ParseClasses.M:
                        serialize.Add("M");
                        break;
                    case ParseClasses.mu:
                        serialize.Add("mu");
                        break;
                    case ParseClasses.N:
                        serialize.Add("N");
                        break;
                    case ParseClasses.neq:
                        serialize.Add("neq");
                        break;
                    case ParseClasses.o:
                        serialize.Add("o");
                        break;
                    case ParseClasses.p:
                        serialize.Add("p");
                        break;
                    case ParseClasses.phi:
                        serialize.Add("phi");
                        break;
                    case ParseClasses.pi:
                        serialize.Add("pi");
                        break;
                    case ParseClasses.pm:
                        serialize.Add("pm");
                        break;
                    case ParseClasses.prime:
                        serialize.Add("prime");
                        break;
                    case ParseClasses.q:
                        serialize.Add("q");
                        break;
                    case ParseClasses.R:
                        serialize.Add("R");
                        break;
                    case ParseClasses.rightarrow:
                        serialize.Add("rightarrow");
                        break;
                    case ParseClasses.S:
                        serialize.Add("S");
                        break;
                    case ParseClasses.sigma:
                        serialize.Add("sigma");
                        break;
                    case ParseClasses.sin:
                        serialize.Add("sin");
                        break;
                    case ParseClasses.sqrt:
                        // TODO...
                        serialize.Add("sqrt");
                        break;
                    case ParseClasses.sum:
                        serialize.Add("sum");
                        break;
                    case ParseClasses.T:
                        serialize.Add("T");
                        break;
                    case ParseClasses.tan:
                        serialize.Add("tan");
                        break;
                    case ParseClasses.theta:
                        serialize.Add("theta");
                        break;
                    case ParseClasses.times:
                        serialize.Add("times");
                        break;
                    case ParseClasses.u:
                        serialize.Add("u");
                        break;
                    case ParseClasses.v:
                        serialize.Add("v");
                        break;
                    case ParseClasses.w:
                        serialize.Add("w");
                        break;
                    case ParseClasses.X:
                        serialize.Add("X");
                        break;
                    case ParseClasses.y:
                        serialize.Add("y");
                        break;
                    case ParseClasses.z:
                        serialize.Add("z");
                        break;
                    default:
                        break;
                }
            }

            return JsonSerializer.Serialize(serialize);
        }
        public string LatexParse(string str)
        {
            string[] inputClasses = str.Split(' ');
            string result = string.Empty;

            foreach (var sym in inputClasses)
            {
                ParseClasses _class = _tokens[sym];

                switch (_class)
                {
                    case ParseClasses.minus:
                        result += "- ";
                        break;
                    case ParseClasses.exclamationMark:
                        result += "! ";
                        break;
                    case ParseClasses.openingBracket:
                        result += "\\left ( ";
                        break;
                    case ParseClasses.closingBracket:
                        result += "\\right ) ";
                        break;
                    case ParseClasses.comma:
                        result += ", ";
                        break;
                    case ParseClasses.openingSquareBracket:
                        result = "\\left [ ";
                        break;
                    case ParseClasses.closingSquareBracket:
                        result = "\\right ] ";
                        break;
                    case ParseClasses.openingCurlyBrace:
                        result += "\\left\\{ ";
                        break;
                    case ParseClasses.closingCurlyBrace:
                        result = "\\right\\} ";
                        break;
                    case ParseClasses.plus:
                        result += "+ ";
                        break;
                    case ParseClasses.equally:
                        result += "= ";
                        break;
                    case ParseClasses.zero:
                        result += "0 ";
                        break;
                    case ParseClasses.one:
                        result += "1 ";
                        break;
                    case ParseClasses.two:
                        result += "2 ";
                        break;
                    case ParseClasses.three:
                        result += "3 ";
                        break;
                    case ParseClasses.four:
                        result += "4 ";
                        break;
                    case ParseClasses.five:
                        result += "5 ";
                        break;
                    case ParseClasses.six:
                        result += "6 ";
                        break;
                    case ParseClasses.seven:
                        result += "7 ";
                        break;
                    case ParseClasses.eight:
                        result += "8 ";
                        break;
                    case ParseClasses.nine:
                        result += "9 ";
                        break;
                    case ParseClasses.A:
                        result += "A ";
                        break;
                    case ParseClasses.alpha:
                        result += "\\alpha ";
                        break;
                    case ParseClasses.ascii_124:
                        result += "| ";
                        break;
                    case ParseClasses.b:
                        result += "b ";
                        break;
                    case ParseClasses.beta:
                        result += "\\beta ";
                        break;
                    case ParseClasses.C:
                        result += "C ";
                        break;
                    case ParseClasses.cos:
                        result += "\\cos ";
                        break;
                    case ParseClasses.d:
                        result += "d ";
                        break;
                    case ParseClasses.delta:
                        result += "\\Delta ";
                        break;
                    case ParseClasses.div:
                        result += "\\div ";
                        break;
                    case ParseClasses.e:
                        result += "e ";
                        break;
                    case ParseClasses.exists:
                        result += "\\exists ";
                        break;
                    case ParseClasses.f:
                        result += "f ";
                        break;
                    case ParseClasses.forall:
                        result += "\\forall ";
                        break;
                    case ParseClasses.forwardSlash:
                        result += "/ ";
                        break;
                    case ParseClasses.G:
                        result += "G ";
                        break;
                    case ParseClasses.gamma:
                        result += "\\gamma ";
                        break;
                    case ParseClasses.geq:
                        result += "\\geq ";
                        break;
                    case ParseClasses.gt:
                        result += "> ";
                        break;
                    case ParseClasses.H:
                        result += "H ";
                        break;
                    case ParseClasses.i:
                        result += "i ";
                        break;
                    case ParseClasses.belongs:
                        result += "\\in ";
                        break;
                    case ParseClasses.infinity:
                        result += "\\infty ";
                        break;
                    case ParseClasses.integral:
                        result += "\\int ";
                        break;
                    case ParseClasses.j:
                        result += "j ";
                        break;
                    case ParseClasses.k:
                        result += "k ";
                        break;
                    case ParseClasses.l:
                        result += "l ";
                        break;
                    case ParseClasses.lambda:
                        result += "\\lambda ";
                        break;
                    case ParseClasses.ldots:
                        result += "\\ldots ";
                        break;
                    case ParseClasses.leq:
                        result += "\\leq ";
                        break;
                    case ParseClasses.lim:
                        result += "\\lim ";
                        break;
                    case ParseClasses.log:
                        result += "\\log ";
                        break;
                    case ParseClasses.lt:
                        result += "< ";
                        break;
                    case ParseClasses.M:
                        result += "M ";
                        break;
                    case ParseClasses.mu:
                        result += "\\mu ";
                        break;
                    case ParseClasses.N:
                        result += "N ";
                        break;
                    case ParseClasses.neq:
                        result += "\\neq ";
                        break;
                    case ParseClasses.o:
                        result += "o ";
                        break;
                    case ParseClasses.p:
                        result += "p ";
                        break;
                    case ParseClasses.phi:
                        result += "\\phi ";
                        break;
                    case ParseClasses.pi:
                        result += "\\pi ";
                        break;
                    case ParseClasses.pm:
                        result += "\\pm ";
                        break;
                    case ParseClasses.prime:
                        result += "\\prime ";
                        break;
                    case ParseClasses.q:
                        result += "q ";
                        break;
                    case ParseClasses.R:
                        result += "R ";
                        break;
                    case ParseClasses.rightarrow:
                        result += "\\rightarrow ";
                        break;
                    case ParseClasses.S:
                        result += "S ";
                        break;
                    case ParseClasses.sigma:
                        result += "\\sigma ";
                        break;
                    case ParseClasses.sin:
                        result += "\\sin ";
                        break;
                    case ParseClasses.sqrt:
                        // TODO...
                        result += "\\sqrt ";
                        break;
                    case ParseClasses.sum:
                        result += "\\sum ";
                        break;
                    case ParseClasses.T:
                        result += "T ";
                        break;
                    case ParseClasses.tan:
                        result += "\\tan ";
                        break;
                    case ParseClasses.theta:
                        result += "\\theta ";
                        break;
                    case ParseClasses.times:
                        result += "\\times ";
                        break;
                    case ParseClasses.u:
                        result += "u ";
                        break;
                    case ParseClasses.v:
                        result += "v ";
                        break;
                    case ParseClasses.w:
                        result += "w ";
                        break;
                    case ParseClasses.X:
                        result += "X ";
                        break;
                    case ParseClasses.y:
                        result += "y ";
                        break;
                    case ParseClasses.z:
                        result += "z ";
                        break;
                    default:
                        break;
                }
            }

            return result;

        }
    }
}

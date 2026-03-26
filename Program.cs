// --- UX / IHC: Saudação e Contexto ---
Console.Clear();
Console.WriteLine("========================================");
Console.WriteLine("   SISTEMA EXPERT: Módulo de Boas-Vindas");
Console.WriteLine("========================================\n");

// --- Entrada de Dados ---
Console.Write("Olá, Recruta! Qual é o seu nome de Desenvolvedor(a)? ");
string nome = Console.ReadLine();
string saudacao = $"Bem-vindo(a), {nome}! Prepare-se para uma jornada de aprendizado e desafios!";
Console.WriteLine($"\n{saudacao}\n");

Console.Write($"Prazer, {nome}! Em qual ano você começou a programar? ");
Console .WriteLine("(Digite apenas o ano, por exemplo: 2015)");
Console.WriteLine("Dica: Quanto mais cedo você começou, mais experiência acumulada você tem! 😉");

string entradaAno = Console.ReadLine();

// --- Lógica Simples ---
int anoInicio = int.Parse(entradaAno);
int anosDeJornada = DateTime.Now.Year - anoInicio;
int anoAtual = DateTime.Now.Year;
int anosDeExperiencia = anoAtual - anoInicio;


// --- Feedback Visual ---
Console.WriteLine("\n----------------------------------------");
Console.WriteLine($"STATUS DO PERFIL: {nome.ToUpper()}");
Console.WriteLine($"ANO DE INÍCIO: {anoInicio}");
Console.WriteLine($"ANO ATUAL: {anoAtual}");
Console.WriteLine($"TEMPO DE ESTRADA: {anosDeJornada} ano(s) de experiência.");
Console.WriteLine("CONSELHO DO DIA: Continue explorando, aprendendo e se desafiando!");
Console.WriteLine("----------------------------------------");

Console.WriteLine("\n[Missão Cumprida! Pressione qualquer tecla para encerrar]");
Console.ReadKey();
Video video1 = new Video(
    "Aprendendo C#",
    "João Silva",
    600);

video1.AddComment(
    new Comment("Maria",
    "Excelente vídeo!"));

video1.AddComment(
    new Comment("Carlos",
    "Muito útil."));

video1.AddComment(
    new Comment("Ana",
    "Gostei bastante."));

Video video2 = new Video(
    "Introdução à Programação",
    "Pedro Souza",
    450);

video2.AddComment(
    new Comment("Lucas",
    "Ótima explicação."));

video2.AddComment(
    new Comment("Juliana",
    "Muito claro."));

video2.AddComment(
    new Comment("Ricardo",
    "Aprendi bastante."));

Video video3 = new Video(
    "Classes e Objetos em C#",
    "Fernanda Lima",
    720);

video3.AddComment(
    new Comment("Amanda",
    "Excelente conteúdo."));

video3.AddComment(
    new Comment("Marcos",
    "Bem explicado."));

video3.AddComment(
    new Comment("Bruno",
    "Muito interessante."));

video1.DisplayVideo();
video2.DisplayVideo();
video3.DisplayVideo();
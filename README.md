Descrição do Problema
Considere que seu grupo foi contratado para desenvolver um programa para gerenciar o processo seletivo da
Universidade Stark. Nesta universidade, os cursos possuem números restritos de vagas e filas de espera limitadas a 10
candidatos. Para seleção dos candidatos deve ser utilizada a média simples das notas da Redação, prova de Matemática
e prova de Linguagens (somar as três notas e dividir por três). Caso ocorra empate de notas entre alunos, o critério de
desempate será a nota da Redação. Persistindo o empate, a nota de Matemática será utilizada como segundo critério de
desempate, e, por fim, a nota de Linguagens como terceiro critério. Para simplificar, vamos considerar que não haverá
casos de dois alunos com médias idênticas e notas iguais em todos os critérios de desempate. Na Universidade Stark,
cada candidato deve selecionar duas opções de curso. Segue abaixo as regras de seleção:
1. Primeira Opção: O candidato selecionado para sua primeira opção de curso não deverá ser colocado em
nenhuma fila de espera.
2. Segunda Opção: O candidato selecionado para sua segunda opção deverá ser colocado na fila de espera da
primeira opção, desde que haja vaga disponível na fila de espera.
3. Nenhuma Opção: Um candidato que não for selecionado para nenhuma de suas opções deverá ser colocado na
fila de espera de ambos os cursos, respeitando o limite de candidatos por fila de espera.
4. Ambas as Opções: Se um candidato for selecionado para suas duas opções de curso, ele deve ser incluído
apenas na lista de candidatos selecionados da sua primeira opção de curso (isto é, deve liberar a vaga da
segunda opção).
O programa deverá ler informações de um arquivo de entrada e ao final do processamento deverá criar um arquivo texto
contendo as seguintes informações:
• Nome e nota de corte de cada curso (A nota de corte de cada curso é a menor nota média dos selecionados para
o curso).
• Lista de candidatos selecionados (nome, nota média, notas da Redação, Matemática e Linguagens), em ordem
decrescente de nota média, considerando os critérios de desempate.
• Fila de espera (nome, nota média, notas da Redação, Matemática e Linguagens), em ordem decrescente de nota
média, considerando os critérios de desempate.
Arquivo de Entrada (entrada.txt)
A primeira linha do arquivo de entrada conterá dois inteiros N e M:
N : número de cursos
M: número de candidatos
As N linhas seguintes terão as seguintes informações sobre os N cursos, separadas por ponto e vírgula: código do curso
(inteiro), nome do curso (string) e quantidade de vagas disponíveis no curso (int).
Após as informações dos cursos, as próximas M linhas terão as informações dos M candidatos. Cada linha terá as
seguintes informações separadas por ponto e vírgula: nome do candidato (string), nota obtida pelo candidato na redação
(double), nota obtida pelo candidato na prova de matemática (double), nota obtida pelo candidato na prova de linguagens
(double), código da primeira opção de curso (int) e o código da segunda opção de curso.
Arquivo de Saída (saida.txt)
Para cada curso, na mesma ordem de entrada, deverá ser escrito em uma mesma linha o nome do curso e a nota de corte
(com duas casas decimais), separados por um espaço.
Na próxima linha deverá ser escrita somente a String “Selecionados”. Em seguida deverão ser escritas Si linhas contendo
o nome do candidato, nota média com duas casas decimais, notas da Redação, Matemática e Linguagens (Si é o número
de candidatos selecionados para o curso i). Os candidatos deverão estar em ordem decrescente de nota média, seguindo
o critério de desempate especificado anteriormente.
Por fim, deverá ser escrita a String “Fila de Espera”. Em seguida, Ei linhas contendo os nomes, notas médias com duas
casas decimais e notas da Redação, Matemática e Linguagens dos candidatos que estão na fila de espera do curso (Ei é
o número de candidatos na fila de espera do curso i). Os candidatos deverão estar em ordem decrescente de nota média,
seguindo o critério de desempate. Para separar as informações de cada curso, escreva uma linha em branco após o último
nome da fila de espera

Além disso, o programa deve ter obrigatoriamente, no mínimo:
• Lista: usar a estrutura de dados List nativa do C# para armazenar a lista de candidatos selecionados de
cada curso.
• Fila: usar a estrutura de dados Fila Linear para armazenar a fila de espera de cada curso. O grupo deverá
implementar a estrutura de dados Fila Linear. Caso necessário, podem ser incluídos métodos na classe
Fila Linear, além dos métodos vistos nas aulas (Obs: Se a Fila já estiver cheia, não deve ser lançada
exceção. Apenas não deve ser feita a inserção).
• Algoritmo de ordenação: o grupo deve implementar e usar no processamento algum algoritmo de
ordenação eficiente.
• Dicionário: usar a estrutura de dados Dicionário nativa do C# para armazenar os cursos

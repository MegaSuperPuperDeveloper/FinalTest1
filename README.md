Данная программа была сделана для того, чтобы вам было просто выводить из данного массива переменные, которые содержат меньше 4х символов. 

В ней есть 4 функции, каждая очевидно отвечает за свою часть решения.
Сначала, программа задает массив длиной от 2 до 6 элементов, затем этот массив отправляется в функцию PullArray,
Эта функция создана для того, чтобы можно было закинуть свои переменные с клавиатуры в массив. Затем, данный массив выводится 
через функция PrintArray, потом вызывается функция ArrayFromCondition, в которой вызывается еще 1 функция(CountOfSymbols),
она нужна для того, чтобы программа выяснила сколько переменных в массиве, имеет менее 4х символов и на основе этого делает
еще 1 массив desiredArray, в самой функции ArrayFromCondition выполняется поставленная задача, далее ответ выводится.

Вот примеры вывода:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

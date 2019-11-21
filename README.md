Dungeons & Dragons Initiative Tracker
=====================================

Основные требования к приложению
--------------------------------

Особое место в настольной ролевой игре Dungeons & Dragons занимают бои. Механика игры определяет бой как последовательность раудов, в течении которого каждый участник совершает один ход. Когда каждый участник драки совершил свой ход раунд заканчивается и начинается новый раунд. Очерёдность ходов определяется броском кубика с добавлением некоторого модификатора.
Отслеживание количества раундов и правильной последовательности ходов персонажей, особенно в ходе насыщенного боя в условиях ограниченного времени (один из приёмов что бы добавить игрокам острых эмоций), является достаточно сложным процессом.
Для помощи ведущему игры предлагается разработать ПО для отслеживания инициативы в бою.

Необходимая функциональность:
- создание отсортированного списка инициативы (пара "Имя персонажа" - Число)
- добавление персонажей игроков на панель быстрого набора чтобы не набирать одни и те же имена каждую драку
- импорт/экспорт сохранённых персонажей из/в файл 
- возможность задания ограничения по времени на ход с автоматическим переходом к следующему персонажу по истечении этого времени
- отображение номера текущего раунда
- отображение сколько времени занимает текущий раунд и ход текущего персонажа
- подсчёт статистики (сколько времени занимает в среднем раунд, сколько времени занимает в среднем ход каждого персонажа) и её отображение в конце боя

Анализ требований
-----------------

![Use case diagram for 'Dungeons & Dragons Initiative Tracker'](http://www.plantuml.com/plantuml/svg/ZLAzJW914ExtARvG62WuUc8CoZKMMFZp0EFTS4pS7x8xfoJ6TtTEB220iVt-PxEBefIr3zvvNYiq8KktKRIIkL59qSthFdQS8bPKbFCSL52ld1juYfrdZEgh6lTHL4ZbdV6SgNdZFFfqG4ngWjksdRriMrAUFN98fX7bC1gYLXIfO-TWePXECTu3M6x8OgomJ1pEeRYkAembR5DMh7CAM8ld2URWdN9iorystltODFtJP9vBGmyEzrBKrbwazjrBpvHFkNCJJaJdTZmfPSKTgNgszcDWtsbGskBLa9DZZvYgkZ5aapv-4HGbjM9foc2JsFY-vGiT3vOAxNCyR3YOoSPA62u9Oi_qvHQci9_t3G00)

Проектирование
--------------

![Class diagram for 'Dungeons & Dragons Initiative Tracker'](http://www.plantuml.com/plantuml/svg/rLZDRXit4BxpANYKK5iF81X2d4GDL1H1ORdjeIW2IZkrsMf_G5AotTJlNYwb9NTdXo8L98TS32_dcrdEDpypgpVQ26NsvOuzoW8ub8rvuIMK6r2QCR7HHecjuSlAIFFoLcZWdnddF_1LCUUoCkoLiUrEQCtVFOeM2Ue4-2XAu7DkzMNrO64z2pV_NLy7V6TWLKaZXP47i53rqZFZhRG70TPT05d6XXYpC51_YItmrHqqjPQcLYytzulJApvtNhxoswAOr9k_v_n-wgnZ-QzD8Gnq42ozWx8-m4GUgHc9ry8AHwS_oghmAjOgbdy0SxlRJQnejQps9IYnsO6zF7iTEERf31wUSS-Zasu6wBTmDrZFSzl3M_TxmRI1dyr84bZ8ItuJm-0KnXoU9oxE5abHuEKi6LaC-2TCnKY0wW3LI5RI89rqwc25Rv50w1rvQOIKo6IAKyIGn2KMWSVfbU8yJNIQtK0fbkFaoo4odprqXicCYkaUjWPra5iOvo8Se38XkVMH3-l3xTR8kcACYdw0Oq-EOsM1j5PbKolJqr8W2b1plZOAH7dddgP8QVcCb9wKD47fT_U4bTvPaG6lDAbwmmvZNMIZM3I64OVNN7d6vuCX6Dg9WsbGKkpal-t5Vz9rjVRFp8KYWt-AO28G3fbDT3QxIKgJF8wpy9Z2-3ZIV6SKT93aTRaH9fNX3lH-hqHBAsQPLBdVgygMjDIFAMGeHcoOw9vtzTwsYT22aBXzQoSbn0C_7F1Ubh1kH1MnzGNGdsKfpJdy6amhEk9sxT-0dKPzxioFcaQdkeZSw_PWWGyGF47g-yONnXNtnXRKHKAaefqBDPGT2DNNOYCoZ52di5ZfI5WtCTb7U3v5EpIR8pRUQU9ZmK6DB44TOw7SmTRP--G-IURylJ3GoevcsvYG4cCl5HSKfp1yGe5t2DbTptU0F_uSg-gWPSMEbzmgJPHcLZrIHKXLNhhSKZMMLLZfQhgqXBv6tMGN2rqXH5dWMXWM06hZRa8CZiwkHBE09YQ4tGE3RYYkhz3BeHIoibIaDoAaFBZIO6HUSJdy8E-rXuWZhjBz3URq9nakppYTsPLqEGMN-as7pYK7bYHM21gEESXH8XVitoGynLBgG_rMRFz9h11eS-lGA7-GrlBvIxIiLrubJmEjU5XfF1CVwwTUFeJS91DZIgalbQhLf0IjnOFF4H8vcOw7Tgt1THNw2_rCi9p5GTZFnWrvwh4HSEY92QkcRZ9mleEUHU4E7RtaQ5Hrj9FnxPLnADpy-9wwjH5choTk5t55V-Ks1VSlgTQEgSdMwVfr8epBA-uiKH9dbn2Ctk8lfWmKawYuRXealZWXGvebSZAMZnZj4t7m6oy2UKi1yLsKRvigKXkvrJHLmmKfymk3M9DqvfPqiIzumvaDViRvHO66rbj6dF7PR84PYE5mesFq40q3ZhW2FWxMYQnbuozyzDKU3EEZer4qHzaRg8fzkViV)
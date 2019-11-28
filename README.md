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

![Class diagram for 'Dungeons & Dragons Initiative Tracker'](http://www.plantuml.com/plantuml/svg/rLZDRXit4BxpANYKKLiF81X674TDLHH1OQdjeIW2QdTgizcV1Kd9TbE_UycLbjmTaY8L98TS32_dcrdEns-6etqZ5HDgLrVaaPT0eUxK2wsXteAGXB2jL88LYYuRnTNBMoQ1VYQK_a1NvOBoHf5NGegAIKdl7fb1WZW2Fh0Qw89gVzuyQDWemlL_LrSEFmHODLnnflWUD5IyZCBOA6R1mOODeCWu424Q1k9lLW1TtKFNIgvQyNAzkJc-ulEGvIkzBSjPk_rdGJSNVNHi_wqhcO81WgttKBTxcF43DPvvpRJHM_sHDwLrqL6n_JseswgQQTDgsUng46nRWTuyUPqaPkbq6Pv8pwAJQJhejqZNHSzBsy9D-gF3r0S_dmT984wNz3g6mHB679ucBivMa2B7osaoSXYmJvWApu3g0DL8bcYGJr8wsE5R20Y_8qz6o2aefZX515cCi49uBAyKvscYq-mwIh4TYo-7o7psq1ecCseEzx0rY3qlmDSYxA5HJjpom8VEuRPGl6q82Ps-W-DC3jVA3V9QrLqhrCXB02j1BEXQwV_g-_xf0Zajdv7Ja-3AEVtHFs6dEsrIO9rcpUYomzZ-P6DOV0qZ3g-ei8ml9fUWQoSzJ8BWhEB_cet_BDjcRP-9EOeS_aC41mx28FE9pcStIMcAHr-51mdZvKZpdGUWKv6tzPQfbC9xqBkTO8PMp7BGPRCJZIvfBXzJI5UCE72WUzwtEzqcN0j2PlFMmHemJ_Cmm0slOTsn9XBh2w2_y9ghK_WrA6Cwu2hprs4leZaFuRscCRZUHFPrkzV01t2P8FTTPmlZajfWDw6Dk9EATYxKK2fWOkn5F38K4yTZqLRFs7OnsmTuFfuscZnD2Y8cv0qlFYteqlp_4slA2eItesLZCj8YtBPjXOqhyvuzgvp2S3AHD6RZdeXB3ZV4-FLaeCeak3WcsgyKVS2Fqhn-GTyn1SPsY6kq4xGeJLxSK1xbyX49j4Tmkx-XK_tvb-ygdPSs6r9okqcgXUJqZL2p27M8T5j8zeAi1f2k-dDB_MlKTsvHnohPBrzSizD2HTTDVvDDbawERdCFVQpsQsoOT0GzoBgWhko-mcK4DUEDvYWvqc7doPOcT_xbfBfq5gF64Kl4j02xWqNuDoMkspZF-ILsDWNdvkqTdLCDjYHce30SSv3Z5Fo5y3k7fvYathTlMV4fCGEXqND08_qWh-Np5tYPhAnBdWUQKR6JVmy-jayZFJXj1eLn4N9V2j6AMGrIiWUhaI3Ils_lgbQ2DnUuapnrM2RYvDXFdXlAr68ZODSi4r5D3qtZR6izYSAjExf9xmuRQ0-UxwYCNU7cd--nMokcTdBM3obzqL_s8qJ_Rz3DjFjPqVlQESFTevUqZnIqcBW1W_SMkp6Xe9n5pMtNOVEvWdGoIsWofaUCja947wdH18jdj--ZV8rKk5Iya66gffDJva-amFmaCyUditF1eyzyyXtgLm4IJBOai4RdynlCG1I76Xs9NQBU1UUsW9TTz81gYV-90drsS87z9HCKtQFa3JJbhgx-1m00)

Зависимости между проектами
---------------------------

![Component diagram for 'Dungeons & Dragons Initiative Tracker'](http://www.plantuml.com/plantuml/svg/SoWkIImgAStDuUAA3ijCBOzLqDEpKuWEA4ejJiqhIIp9pC-BHP7npKz9pK4LSd7q0GeWQq5L2rA0AiBba9gN0hGK0000)

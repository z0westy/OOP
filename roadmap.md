# Мой Roadmap по Backend Python

---

## 1. Основы Python (недели 1-4)

- [ ] Синтаксис, переменные, типы данных
- [ ] Условные операторы (if/elif/else)
- [ ] Циклы (for, while)
- [ ] Списки (list), кортежи (tuple), словари (dict), множества (set)
- [ ] Функции, аргументы (*args, **kwargs), return
- [ ] Lambda-функции
- [ ] Работа с файлами (open, with)
- [ ] Обработка исключений (try/except/finally)
- [ ] ООП: классы, объекты, наследование, магические методы
- [ ] Импорты, модули, if __name__ == "__main__"

**Практика:**
- [ ] Решить 30-50 задач на Codewars (уровень 5-6 kyu)
- [ ] Написать простой парсер файлов (csv/json)

**Материалы:**
- Stepik: «Поколение Python» (для начинающих и продвинутых)
- Книга: «Автоматизация рутинных задач с помощью Python»
- Codewars: https://www.codewars.com

---

## 2. Инструменты разработчика (недели 5-6)

- [ ] Git: init, add, commit, push, pull, branch, merge
- [ ] GitHub: создание репозитория, Pull Request
- [ ] Виртуальные окружения: venv, pip freeze
- [ ] Poetry (менеджер зависимостей)
- [ ] Линтеры: flake8, black
- [ ] Linux: базовые команды (ls, cd, grep, chmod, ps, ssh)

**Практика:**
- [ ] Создать GitHub профиль, залить первый проект
- [ ] Настроить виртуальное окружение для каждого проекта

**Материалы:**
- Learn Git Branching: https://learngitbranching.js.org
- Stepik: «Git для начинающих»
- Stepik: «Введение в Linux»

---

## 3. SQL и Базы данных (недели 7-9)

- [ ] PostgreSQL (установка, psql)
- [ ] SELECT, WHERE, ORDER BY
- [ ] JOIN (INNER, LEFT, RIGHT)
- [ ] GROUP BY, HAVING, агрегатные функции
- [ ] Вложенные запросы (subqueries)
- [ ] Индексы (базовое понимание)
- [ ] psycopg2 (подключение из Python)
- [ ] SQLAlchemy Core (базово)

**Практика:**
- [ ] Спроектировать БД для интернет-магазина (3-4 таблицы)
- [ ] Написать 10 сложных запросов с JOIN

**Материалы:**
- SQLBolt: https://sqlbolt.com
- Stepik: «Основы SQL» (с сертификатом)
- Stepik: «PostgreSQL для начинающих»
- Книга: «SQL для аналитиков и разработчиков»

---

## 4. FastAPI (недели 10-14)

- [ ] Установка, первый эндпоинт
- [ ] Path и Query параметры
- [ ] Request Body, Pydantic модели
- [ ] Dependency Injection (Depends)
- [ ] Асинхронность: async/await
- [ ] Подключение БД: SQLAlchemy 2.0 + asyncpg
- [ ] Миграции: Alembic
- [ ] JWT авторизация (access/refresh токены)
- [ ] CORS, middleware
- [ ] Документация: Swagger, ReDoc

**Практика:**
- [ ] TODO-API с пользователями и задачами (JWT, БД)
- [ ] Докеризовать проект (Dockerfile + docker-compose)

**Материалы:**
- Официальная документация FastAPI: https://fastapi.tiangolo.com
- Stepik: «FastAPI: создание API»
- YouTube: канал «selfedu» (плейлист FastAPI)
- Статья: SQLAlchemy 2.0 на Habr

---

## 5. Docker и контейнеризация (недели 15-16)

- [ ] Docker: образы, контейнеры, Dockerfile
- [ ] docker-compose: связка app + postgres + redis
- [ ] Переменные окружения (.env)
- [ ] Монтирование томов (volumes)

**Практика:**
- [ ] Завернуть свой FastAPI проект в docker-compose
- [ ] Настроить volumes для разработки (hot reload)

**Материалы:**
- Stepik: «Docker для начинающих»
- YouTube: «Docker для разработчиков» (канал «DevOps для программистов»)
- Документация Docker: https://docs.docker.com

---

## 6. Асинхронность и фоновые задачи (недели 17-18)

- [ ] asyncio: event loop, tasks, gather
- [ ] Celery: настройка, задачи, очереди
- [ ] Celery Beat (периодические задачи)
- [ ] Redis как брокер

**Практика:**
- [ ] Добавить в проект отправку email (или очистку старых задач) через Celery
- [ ] Настроить Celery Beat для ежедневного отчета

**Материалы:**
- Stepik: «Асинхронный Python»
- YouTube: «Celery для начинающих» (канал «devman»)
- Книга: «Python. Асинхронное программирование»

---

## 7. Тестирование (недели 19-20)

- [ ] pytest: фикстуры, маркеры, параметризация
- [ ] mock: unittest.mock, подмена внешних вызовов
- [ ] Тестирование API: TestClient (FastAPI)
- [ ] Покрытие кода: coverage.py

**Практика:**
- [ ] Написать тесты для своего FastAPI проекта (юнит + интеграционные)
- [ ] Добиться покрытия >70%

**Материалы:**
- Stepik: «pytest: тестирование на Python»
- Статья: «Pytest: полное руководство» (Habr)
- Официальная документация pytest

---

## 8. Деплой и CI/CD (недели 21-22)

- [ ] Nginx (reverse proxy)
- [ ] Gunicorn / Uvicorn (ASGI сервер)
- [ ] GitHub Actions: автоматический запуск тестов и деплой
- [ ] VPS: DigitalOcean / Hetzner / Yandex Cloud

**Практика:**
- [ ] Задеплоить проект на VPS (Ubuntu + Docker + Nginx)
- [ ] Настроить GitHub Actions: при пуше в main → тесты → деплой

**Материалы:**
- Статья: «Настройка Nginx + Gunicorn» (Habr)
- GitHub Actions docs: https://docs.github.com/actions
- DigitalOcean tutorials: https://www.digitalocean.com/community/tutorials

---

## 9. Дополнительно (по желанию, недели 23-24)

- [ ] Redis: кэширование, хранение сессий
- [ ] WebSockets (в FastAPI)
- [ ] Микросервисная архитектура (базово)
- [ ] Clean Architecture / DDD (базово)

**Материалы:**
- Redis docs: https://redis.io/docs
- Статья: «WebSockets в FastAPI» (Habr)
- Книга: «Чистая архитектура» (Роберт Мартин)

---

## 10. Подготовка к собеседованиям (параллельно с недель 1-24)

### Вопросы по темам:
- [ ] Python: декораторы, генераторы, GIL, mutable/immutable
- [ ] ООП: наследование, полиморфизм, композиция
- [ ] SQL: JOIN, индексы, транзакции, ACID
- [ ] FastAPI: dependency injection, middleware, lifespan events
- [ ] Docker: отличие образа от контейнера, слои
- [ ] Алгоритмы: массивы, строки, словари, рекурсия

### Ресурсы:
- GitHub: python-interview-questions (https://github.com/learning-zone/python-interview-questions)
- GitHub: fastapi-interview-questions (https://github.com/learning-zone/fastapi-interview-questions)
- LeetCode: задачи Easy/Medium (50-100)
- Habr: статьи по собеседованиям Python

### Практика:
- [ ] Написать шпаргалки по каждой теме
- [ ] Пройти 3-5 mock-интервью с другом или на Pramp

---

## 11. Поиск работы (недели 20-24)

### Платформы:
- [ ] LinkedIn (профиль на английском, #OpenToWork)
- [ ] HeadHunter / Rabota.by / Habr Career
- [ ] Telegram-каналы: @python_jobs, @vakansii_junior, @job_for_developers

### Холодные отклики:
- [ ] Цель: 30-50 откликов в неделю
- [ ] Сопроводительное письмо (шаблон, адаптировать под вакансию)

### Горячие письма:
- [ ] Найти 50-100 IT-компаний (Devby, GitHub списки)
- [ ] Отправить письмо на hr@company.com с резюме и GitHub

### План собеседований:
- [ ] Цель: пройти 15-20 технических собеседований
- [ ] После каждого отказа запрашивать обратную связь
- [ ] Вести таблицу: компания, этап, дата, результат

---

## 12. Финальный проект (недели 21-24)

### Сервис сокращения ссылок (или аналог)
- [ ] FastAPI + PostgreSQL + SQLAlchemy
- [ ] JWT авторизация (регистрация, логин)
- [ ] Создание коротких ссылок (алгоритм хэширования)
- [ ] Переход по ссылке + счетчик кликов
- [ ] Кэширование популярных ссылок в Redis
- [ ] Фоновая задача (Celery) для удаления неактивных ссылок
- [ ] Тесты (pytest)
- [ ] Docker + docker-compose
- [ ] Деплой на VPS
- [ ] GitHub Actions (тесты при PR, авто-деплой)
- [ ] README.md с описанием, скриншотами, как запустить

---

## Каналы поиска
- [ ] LinkedIn: отклики на вакансии, писать рекрутерам напрямую
- [ ] Telegram-каналы компаний (подписаться на все, где публикуют стажировки)
- [ ] Хабр Карьера: фильтр по Python Junior
- [ ] Лекции от компаний в университете (нетворкинг)

---

**Временная шкала: 6-8 месяцев (15-20 часов в неделю)**
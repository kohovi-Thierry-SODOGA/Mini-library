# Buber books API

- [Books API](#books-api)
  - [Create Books](#create-books)
    - [Create Books](#create-books-request)
    - [Create Books Response](#create-books-response)
  - [Get Books](#get-books)
    - [Get Books Request](#get-books-request)
    - [Get  Response](#get-books-response)
  - [Update books](#update-books)
    - [Update books Request](#update-books-request)
    - [Update books Response](#update-books-response)
  - [Delete books](#delete-books)
    - [Delete books Request](#delete-books-request)
    - [Delete books Response](#delete-books-response)

## Create books

### Create books Request

```js
POST /bookss
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy books..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create books Response

```js
201 Created
```

```yml
Location: {{host}}/bookss/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy books..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get books

### Get books Request

```js
GET /bookss/{{id}}
```

### Get books Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy books..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update books

### Update books Request

```js
PUT /bookss/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy books..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update books Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/bookss/{{id}}
```

## Delete books

### Delete books Request

```js
DELETE /bookss/{{id}}
```

### Delete books Response

```js
204 No Content
```
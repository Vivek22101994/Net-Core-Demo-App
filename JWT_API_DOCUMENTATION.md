# JWT Authentication API Documentation

## Overview

This document describes the JWT Authentication API endpoints added to your WebApplication4. The API provides secure token-based authentication using JSON Web Tokens (JWT).

## Base URL

```
https://localhost:5001/api/auth
```

## Endpoints

### 1. Login / Generate Token

**Endpoint:** `POST /api/auth/login`

**Description:** Authenticates a user and returns a JWT token.

**Authentication:** Not required (Public endpoint)

**Request Body:**
```json
{
  "username": "string (username, login field, or email)",
  "password": "string"
}
```

**Response (200 OK):**
```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "expiresIn": 3600,
  "tokenType": "Bearer",
  "user": {
    "id": 1,
    "username": "admin",
    "email": "admin@example.com"
  }
}
```

**Error Responses:**
- `400 Bad Request` - Missing credentials
- `401 Unauthorized` - Invalid username or password
- `500 Internal Server Error` - Server error during authentication

**Example cURL:**
```bash
curl -X POST https://localhost:5001/api/auth/login \
  -H "Content-Type: application/json" \
  -d '{
    "username": "admin",
    "password": "password123"
  }'
```

**Example JavaScript/Fetch:**
```javascript
const response = await fetch('https://localhost:5001/api/auth/login', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
  },
  body: JSON.stringify({
    username: 'admin',
    password: 'password123'
  })
});

const data = await response.json();
console.log('Token:', data.token);
```

---

### 2. Validate Token

**Endpoint:** `POST /api/auth/validate`

**Description:** Validates a JWT token and returns the claims.

**Authentication:** Not required

**Request Body:**
```json
"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
```

**Response (200 OK):**
```json
{
  "message": "Token is valid",
  "claims": [
    {
      "type": "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
      "value": "1"
    },
    {
      "type": "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name",
      "value": "admin"
    },
    {
      "type": "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress",
      "value": "admin@example.com"
    }
  ]
}
```

**Error Responses:**
- `400 Bad Request` - Token not provided
- `401 Unauthorized` - Invalid or expired token
- `500 Internal Server Error` - Server error during validation

---

### 3. Get Current User

**Endpoint:** `GET /api/auth/me`

**Description:** Retrieves information about the currently authenticated user.

**Authentication:** Required (Bearer Token)

**Response (200 OK):**
```json
{
  "id": "1",
  "username": "admin",
  "email": "admin@example.com"
}
```

**Error Responses:**
- `401 Unauthorized` - Not authenticated or invalid token
- `500 Internal Server Error` - Server error

**Example cURL:**
```bash
curl -X GET https://localhost:5001/api/auth/me \
  -H "Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
```

---

### 4. Refresh Token

**Endpoint:** `POST /api/auth/refresh`

**Description:** Generates a new JWT token using the current valid token.

**Authentication:** Required (Bearer Token)

**Response (200 OK):**
```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
  "expiresIn": 3600,
  "tokenType": "Bearer",
  "user": {
    "id": 1,
    "username": "admin",
    "email": "admin@example.com"
  }
}
```

**Error Responses:**
- `401 Unauthorized` - Not authenticated or invalid token
- `500 Internal Server Error` - Server error

**Example cURL:**
```bash
curl -X POST https://localhost:5001/api/auth/refresh \
  -H "Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
```

---

## Authentication

### Bearer Token Format

All protected endpoints require an `Authorization` header with a Bearer token:

```
Authorization: Bearer {token}
```

### How to Use the Token

1. **Login** to get a token:
   ```bash
   POST /api/auth/login
   ```

2. **Include the token** in subsequent requests:
   ```
   Authorization: Bearer {your_token_here}
   ```

3. **Token Expiration**: Tokens expire after the configured time (default: 60 minutes). Use `/api/auth/refresh` to get a new token.

---

## Configuration

JWT settings are configured in `appsettings.json`:

```json
{
  "JwtSettings": {
    "SecretKey": "your-super-secret-key-change-this-in-production-minimum-32-characters",
    "Issuer": "WebApplication4",
    "Audience": "WebApplication4Users",
    "ExpiryMinutes": 60
  }
}
```

### Important Security Notes

⚠️ **PRODUCTION SECURITY REQUIREMENTS:**

1. **Change the SecretKey** - Use a strong, randomly generated key (minimum 32 characters)
2. **Use HTTPS only** - Set `RequireHttpsMetadata = true` in production
3. **Implement Password Hashing** - Currently using plain text comparison. Implement BCrypt or similar
4. **Store Tokens Securely** - Use HttpOnly cookies or secure storage
5. **Enable CORS carefully** - Restrict to trusted domains only

---

## Token Claims

The JWT token includes the following claims:

| Claim | Type | Value |
|-------|------|-------|
| `NameIdentifier` | `http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier` | User ID |
| `Name` | `http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name` | Username |
| `Email` | `http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress` | Email Address |
| `UniqueId` | `UniqueId` | User's Unique GUID |
| `RoleId` | `RoleId` | User's Role ID |

---

## Common Status Codes

| Code | Meaning |
|------|---------|
| 200 | Success |
| 400 | Bad Request (missing/invalid data) |
| 401 | Unauthorized (invalid credentials or token) |
| 500 | Internal Server Error |

---

## Files Added/Modified

### New Files Created:
- `Controllers/AuthController.cs` - Main authentication API controller
- `Services/JwtTokenService.cs` - JWT token generation and validation service
- `Models/JwtTokenRequest.cs` - Login request model
- `Models/JwtTokenResponse.cs` - Token response model

### Modified Files:
- `Program.cs` - Added JWT authentication middleware configuration
- `appsettings.json` - Added JWT settings configuration
- `WebApplication4.csproj` - Added required NuGet packages:
  - `System.IdentityModel.Tokens.Jwt`
  - `Microsoft.AspNetCore.Authentication.JwtBearer`

---

## Testing

### Using Postman

1. **Login Request:**
   - Method: `POST`
   - URL: `https://localhost:5001/api/auth/login`
   - Body (JSON):
     ```json
     {
       "username": "admin",
       "password": "password123"
     }
     ```

2. **Use Token in Protected Endpoint:**
   - Copy the token from login response
   - In Headers tab, add:
     - Key: `Authorization`
     - Value: `Bearer {paste_token_here}`
   - Make request to `https://localhost:5001/api/auth/me`

---

## Next Steps

1. **Update appsettings.json** - Change the `SecretKey` to a production-secure value
2. **Implement Password Hashing** - Add BCrypt NuGet package and hash passwords
3. **Add Role-Based Authorization** - Extend `[Authorize]` attributes with roles
4. **Configure HTTPS** - Ensure all traffic uses HTTPS
5. **Add Rate Limiting** - Protect login endpoint from brute force attacks
6. **Implement Token Blacklist** - For logout functionality
7. **Add Refresh Token Rotation** - Enhance security with rotating refresh tokens

---

## Support & Troubleshooting

### Common Issues

**Issue: "JWT SecretKey is not configured"**
- Solution: Ensure `appsettings.json` contains the `JwtSettings` section with `SecretKey`

**Issue: "Token validation failed"**
- Solution: Verify token is not expired and SecretKey matches between generation and validation

**Issue: 401 Unauthorized on protected endpoints**
- Solution: Ensure `Authorization: Bearer {token}` header is included in the request

---

## License

This API implementation is part of WebApplication4.


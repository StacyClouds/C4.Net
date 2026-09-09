---
title: Client-side encryption
---

# Client-side encryption

`C4.Net.Client` can encrypt a workspace before upload so the encrypted payload is stored remotely and the passphrase remains with the client.

> Note: client-side encryption depends on support from the target Structurizr-compatible service.

## Namespaces

```csharp
using C4.Net.Api;
using C4.Net.Encryption;
```

## Enable encryption

```csharp
StructurizrClient client = new StructurizrClient("key", "secret");
client.EncryptionStrategy = new AesEncryptionStrategy("password");
client.PutWorkspace(1234, workspace);
```

## Advanced configuration

`AesEncryptionStrategy` defaults to a 128-bit key size and 1000 iterations. Use the overload that accepts key size, iteration count, and passphrase when you need to control those values explicitly.

See `C4.Net.Examples/ClientSideEncryption.cs` for a complete example.

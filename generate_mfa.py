import pyotp
import qrcode

totp = pyotp.TOTP(pyotp.random_base32())
secret = totp.secret

uri = totp.provisioning_uri("MyPc", issuer_name="Solar-Access-Guard")
img = qrcode.make(uri)
img.show()

print(f"Generated Secret: {secret}")
